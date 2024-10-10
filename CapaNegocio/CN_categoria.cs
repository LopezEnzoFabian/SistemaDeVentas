using Capa_Entidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_categoria
    {
        private CD_categoria ocd_Categoria = new CD_categoria();
        public List<Categoria> Listar()
        {
            return ocd_Categoria.Listar();
        }

        //metodos para hacer el llamado desde nuestra capa de presentacion
        public int Registrar(Categoria obj, out string Mensaje)
        {
            return ocd_Categoria.Registrar(obj, out Mensaje);
        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            return ocd_Categoria.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return ocd_Categoria.Eliminar(obj, out Mensaje);
        }
    }
}
