using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Capa_Entidad;

namespace CapaNegocio
{
    public class CN_usuario
    {
        private CD_usuario ocd_usuario = new CD_usuario();
        public List<Usuario> Listar()
        {
            return ocd_usuario.Listar();
        }

    }
}
