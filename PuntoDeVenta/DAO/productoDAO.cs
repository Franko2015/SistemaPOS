using MySql.Data.MySqlClient;
using PuntoDeVenta.Cache;
using PuntoDeVenta.DAO.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.DAO
{
    public class productoDAO : ConnectionToMysql
    {
        public bool Create(int codigo, string producto, int precio, int stock)
        {
            bool positive = true;

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand())
                {


                    string Query = "INSERT INTO productos(codigo, producto, precio, stock) VALUES(@codigo,@producto,@precio,@stock);";

                    MySqlCommand cmd = new MySqlCommand(Query, connection);

                    cmd.Connection = connection;

                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@producto", producto);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@stock", stock);

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

        public bool Read()
        {

            using (var connection = GetConnection())
            {

                connection.Open();

                using (var command = new MySqlCommand())
                {

                    string stm = "select LPAD(codigo, 5, '0'), producto, precio, stock from productos LIMIT 100;";
                    var cmd = new MySqlCommand(stm, connection);

                    cmd.Connection = connection;
                    cmd.CommandText = stm;
                    cmd.CommandType = CommandType.Text;

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            productos.Codigo = reader.GetInt32(0);
                            productos.Producto = reader.GetString(1);
                            productos.Precio = reader.GetInt32(2);
                            productos.Stock = reader.GetInt32(3);
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
