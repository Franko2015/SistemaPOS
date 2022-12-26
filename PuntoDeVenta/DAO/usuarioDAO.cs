using MySql.Data.MySqlClient;
using PuntoDeVenta.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.DAO
{
    public class usuarioDAO : ConnectionToMysql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {

                connection.Open();

                using (var command = new MySqlCommand())
                {

                    string stm = "SELECT * FROM usuarios WHERE usuario = @user AND contrasena =@pass;";
                    var cmd = new MySqlCommand(stm, connection);
                    cmd.Connection = connection;
                    cmd.CommandText = stm;
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.CommandType = CommandType.Text;

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheLogin.id = reader.GetInt32(0);
                            CacheLogin.Usuario = reader.GetString(1);
                            CacheLogin.Contraseña = reader.GetString(2);
                            CacheLogin.TipoUsuario = reader.GetString(3);
                        }
                        return true;
                    }
                    else
                        return false;

                }
            }

        }



        public bool Create(string user, string pass, string tipo)
        {
            bool positive = true;

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand())
                {


                    string Query = "INSERT INTO usuarios(usuario, contrasena, TipoUsuario) VALUES(@user,@pass,@tipo);";

                    MySqlCommand cmd = new MySqlCommand(Query, connection);

                    cmd.Connection = connection;

                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@tipo", tipo);

                    cmd.CommandType = CommandType.Text;

                    cmd.ExecuteNonQuery();

                    if (positive == true)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                        return false;
                }

            }
        }
    }
}
