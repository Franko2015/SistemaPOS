using PuntoDeVenta.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Model
{
    public class ProductoModelo
    {
        productoDAO p = new productoDAO();

        public bool Create(int codigo, string producto, int precio, int stock)
        {
            return p.Create(codigo, producto, precio, stock);
        }

        public bool Read()
        {
            return p.Read();
        }
    }
}
