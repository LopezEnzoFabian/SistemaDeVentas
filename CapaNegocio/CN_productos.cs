using Capa_Entidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_productos
    {
        private CD_producto ocd_productos = new CD_producto();
        public List<Producto> Listar()
        {
            return ocd_productos.Listar();
        }

        //metodos para hacer el llamado desde nuestra capa de presentacion
        public int Registrar(Producto obj, out string Mensaje)
        {
            return ocd_productos.Registrar(obj, out Mensaje);
        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            return ocd_productos.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return ocd_productos.Eliminar(obj, out Mensaje);
        }

    }
}
