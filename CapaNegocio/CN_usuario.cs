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

        //metodos para hacer el llamado desde nuestra capa de presentacion
        public int Registrar(Usuario obj,out string Mensaje)
        {
            return ocd_usuario.Registrar(obj,out Mensaje);
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            return ocd_usuario.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return ocd_usuario.Eliminar(obj, out Mensaje);
        }

    }
}
