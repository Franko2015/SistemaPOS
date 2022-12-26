using MySql.Data.MySqlClient;
using PuntoDeVenta.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Usuarios
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
            tipo.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Text != "" || pass.Text != "" || tipo.SelectedIndex != 0)
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
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM usuarios WHERE usuario =" + user.Text + "", cn);


            if (da != null)
            {
                UsuarioModelo u = new UsuarioModelo();
                u.Create(user.Text, pass.Text, tipo.SelectedItem.ToString().ToUpper());
                MessageBox.Show("¡Usuario ha sido registrado con éxito!","Usuario registrado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Intente con otro nombre", "Usuario ya existe");
                cn.Close();
                vaciar();
            }
        }
        private void vaciar()
        {
            user.Clear();
            pass.Clear();

        }

        private void user_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
