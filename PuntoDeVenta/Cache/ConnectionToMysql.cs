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
            connectionString = "datasource=localhost;port=3306;username=root;password=;database=puntodeventa;";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
