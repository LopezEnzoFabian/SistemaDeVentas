using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Entidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Rol
    {
        private CDRol objcd_rol = new CDRol();

        public List<Rol> Listar()
        {
            return objcd_rol.Listar();
        }
    }
}
