using MySql.Data.MySqlClient;
using PuntoDeVenta.Usuarios;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using PuntoDeVenta.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace PuntoDeVenta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
            {
                if (user.Text != "" || pass.Text != "")
                {

                UsuarioModelo m = new UsuarioModelo();
                var validar = m.LoginUser(user.Text, pass.Text);
                if (validar == true)
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                    MessageBox.Show("¡Ingreso Exitoso!");
                }
                else {
                    MessageBox.Show("¡Usuario no existe!");
                }
            }
            else
            {
                MessageBox.Show("Complete los campos para iniciar sesión");
            }
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e){}

        private void pass_KeyPress(object sender, KeyPressEventArgs e){}

        private void user_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
    }