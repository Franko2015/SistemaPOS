using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoDeVenta.DAO;

namespace PuntoDeVenta.Model
{
    public class UsuarioModelo
    {
        usuarioDAO u = new usuarioDAO();
        public bool LoginUser(string user, string pass)
        {
            return u.Login(user, pass);
        }
        public bool Create(string user, string pass, string tipo)
        {
            return u.Create(user, pass, tipo);
        }

    }
}
