using Capa_Entidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_cliente
    {
        private CD_cliente ocd_cliente = new CD_cliente();
        public List<Cliente> Listar()
        {
            return ocd_cliente.Listar();
        }

        //metodos para hacer el llamado desde nuestra capa de presentacion
        public int Registrar(Cliente obj, out string Mensaje)
        {
           return ocd_cliente.Registrar(obj, out Mensaje);
        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
          return ocd_cliente.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
          return ocd_cliente.Eliminar(obj, out Mensaje);
        }
    }
}
