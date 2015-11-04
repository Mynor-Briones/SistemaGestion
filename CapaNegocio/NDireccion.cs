using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NDireccion
    {
        public static DDireccion BuscarPorId(int id)
        {
            return new DDireccion().BuscarPorId(id);
        }
    }
}
