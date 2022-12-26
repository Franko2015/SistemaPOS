using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.DAO.Clases
{
    public static class ventas
    {
        public static int id { get; set; }
        public static int Producto { get; set; }
        public static int Usuario { get; set; }
        public static int Almacen { get; set; }
        public static string FechaHora { get; set; }
    }
}
