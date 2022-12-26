using MySql.Data.MySqlClient;
using PuntoDeVenta.Cache;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoDeVenta.DAO.Clases;

namespace PuntoDeVenta.DAO
{
    public class ventaDAO : ConnectionToMysql
    {

        public bool Create(int producto, int usuario, int almacen, string FechaHora)
        {
            bool positive = true;

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand())
                {
                    

                    string Query = "INSERT INTO ventas(producto, usuario, almacen, fecha_hora) VALUES(@producto,@usuario,@almacen,@FechaHora);";

                    MySqlCommand cmd = new MySqlCommand(Query, connection);

                    cmd.Connection = connection;

                    cmd.Parameters.AddWithValue("@producto", producto);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@almacen", almacen);
                    cmd.Parameters.AddWithValue("@FechaHora", FechaHora);

                    cmd.CommandType = CommandType.Text;

                    cmd.ExecuteNonQuery();

                    if (positive == true)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                        return false ;
                }

            }
        }

        public bool Read()
        {

            using (var connection = GetConnection())
            {

                connection.Open();

                using (var command = new MySqlCommand())
                {

                    string stm = "SELECT ventas.id, p.producto, u.usuario, a.nombre_razon_social FROM ventas inner join productos p, usuarios u, almacen a where p.codigo = ventas.producto;";
                    var cmd = new MySqlCommand(stm, connection);
                    cmd.Connection = connection;
                    cmd.CommandText = stm;
                    cmd.CommandType = CommandType.Text;

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ventas.id = reader.GetInt32(0);
                            ventas.Producto = reader.GetInt32(1);
                            ventas.Usuario = reader.GetInt32(2);
                            ventas.Almacen = reader.GetInt32(3);
                            ventas.FechaHora = reader.GetString(4);
                        }
                        return true;
                    }
                    else
                        return false;

                }

            }
        }

    }
}
