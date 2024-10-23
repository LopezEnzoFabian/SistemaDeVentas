using Capa_Entidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_proveedor
    {
        private CD_proveedor ocd_proveedor = new CD_proveedor();
        public List<Proveedor> Listar()
        {
            return ocd_proveedor.Listar();
        }

        //metodos para hacer el llamado desde nuestra capa de presentacion
        public int Registrar(Proveedor obj, out string Mensaje)
        {
            return ocd_proveedor.Registrar(obj, out Mensaje);
        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            return ocd_proveedor.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return ocd_proveedor.Eliminar(obj, out Mensaje);
        }
    }
}

