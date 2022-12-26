using MySql.Data.MySqlClient;
using PuntoDeVenta.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Productos
{
    public partial class CrearProducto : Form
    {
        public CrearProducto()
        {
            InitializeComponent();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            if (codigo.Text != "" || nombreProducto.Text != "" || precio.Text != "" || stock.Text != "")
            {
                crear();
            }
            else
            {
                MessageBox.Show("Espacios sin completar", "Debe llenar los campos para continuar");
            }
            
        }

        private void crear()
        {
            MySqlConnection cn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=puntodeventa;");
            cn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM productos WHERE CODIGO ="+codigo.Text+"", cn);


            if (da != null)
            {
                ProductoModelo p = new ProductoModelo();
                p.Create(Int32.Parse(codigo.Text), nombreProducto.Text.ToUpper(), Int32.Parse(precio.Text), Int32.Parse(stock.Text));
                
                MessageBox.Show("¡Producto creado con éxito!");
                vaciar();
                this.Close();
            }
            else
            {
                MessageBox.Show("Producto ya existe", "Intente con otro producto");
                cn.Close();
                vaciar();
            }
        }
        private void vaciar()
        {
            codigo.Clear();
            nombreProducto.Clear();
            precio.Clear();
            stock.Clear();

        }
    }
}
