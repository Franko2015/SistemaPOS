using MySql.Data.MySqlClient;
using PuntoDeVenta.Cache;
using PuntoDeVenta.Model;
using PuntoDeVenta.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Usuarios
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            llenarTabla();
            datosUsuario();
            var timer = new System.Timers.Timer(TimeSpan.FromMinutes(10).TotalMilliseconds); // se ejecutara cada 10 minutos
            timer.Elapsed += async (sender, e) => {
                datosUsuario();
            };
            timer.Start();
            timer1.Start();
        }

        private void datosUsuario()
        {
            Usuario.Text = CacheLogin.Usuario.ToUpper();
            Tipo.Text = CacheLogin.TipoUsuario;
            Hora.Text = DateTime.Now.ToString("h:mm:ss tt");

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void llenarTabla()
        {
            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=puntodeventa;");

            string where = " where 1=1 ";

            if (codigo.Text != "")
            {
                where = where + " and codigo like'%" + codigo.Text + "%' ";
            }

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT LPAD(codigo, 5, '0') as CODIGO, PRODUCTO, PRECIO, STOCK FROM productos" + where + " ;", cn);

            da.Fill(dt);

            this.dataGridView1.DataSource = dt;


        }

        private void RegistrarNuevoProducto(object sender, EventArgs e)
        {
            this.Close();
            CrearProducto cP = new CrearProducto();
            cP.Show();
        }

        private void ActualizarTabla(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void ActualizarProducto(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void registrarNuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearProducto cP = new CrearProducto();
            cP.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=puntodeventa;");

            string where = " where 1=1 ";

            if (codigo.Text != "")
            {
                where = where + " and codigo like'%" + codigo.Text + "%' ";
            }

            if (producto.Text != "")
            {
                where = where + " and producto like'%" + producto.Text + "%' ";
            }

            if (precio.Text != "")
            {
                where = where + " and precio like'%" + precio.Text + "%' ";
            }

            string query = "SELECT LPAD(codigo, 5, '0') as CODIGO, PRODUCTO, PRECIO, STOCK FROM productos" + where + " ;";

            MySqlCommand comandoDB = new MySqlCommand(query, cn);
            comandoDB.CommandTimeout = 60;
            MySqlDataReader reader;
            dataGridView1.Refresh();
            try {

                llenarTabla();

            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            } 
            }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=puntodeventa;");

            string where = " where 1=1 ";

            if (codigo.Text != "")
            {
                where = where + " and codigo like'%" + codigo.Text + "%' ";
            }

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT LPAD(codigo, 5, '0') as CODIGO, PRODUCTO, PRECIO, STOCK FROM productos" + where + " ;", cn);

            da.Fill(dt);

            this.dataGridView1.DataSource = dt;
        }

        private void producto_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=puntodeventa;");

            string where = " where 1=1 ";

            if (producto.Text != "")
            {
                where = where + " and producto like'%" + producto.Text + "%' ";
            }

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT LPAD(codigo, 5, '0') as CODIGO, PRODUCTO, PRECIO, STOCK FROM productos" + where + " ;", cn);

            da.Fill(dt);

            this.dataGridView1.DataSource = dt;
        }

        private void precio_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=puntodeventa;");

            string where = " where 1=1 ";

            if (precio.Text != "")
            {
                where = where + " and precio like'%" + precio.Text + "%' ";
            }

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT LPAD(codigo, 5, '0') as CODIGO, PRODUCTO, PRECIO, STOCK FROM productos" + where + " ;", cn);

            da.Fill(dt);

            this.dataGridView1.DataSource = dt;
        }

        private void registrarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearUsuario cU = new CrearUsuario();
            cU.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cierre_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar la sesión?", "Espera",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datosUsuario();
        }
    }
    }
