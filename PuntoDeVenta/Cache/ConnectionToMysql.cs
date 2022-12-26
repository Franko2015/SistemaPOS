using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Cache
{
    public abstract class ConnectionToMysql
    {
        private readonly string connectionString;
        public ConnectionToMysql()
        {
            connectionString = "datasource=192.168.1.43;port=3306;username=puntodeventa;password=puntodeventa;database=puntodeventa;";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
