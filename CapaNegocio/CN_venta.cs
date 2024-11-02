using Capa_Entidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_venta
    {
        private CD_venta objcd_venta = new CD_venta();

        //pasamos los metodos de nuestra capa de datos

        public bool RestarStock(int idproducto, int cantidad)
        {
            return objcd_venta.RestarStock(idproducto, cantidad);
        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            return objcd_venta.SumarStock(idproducto, cantidad);
        }


        public int OptenerCorrelativo()
        {
            return objcd_venta.OptenerCorrelativo();
        }

        //metodos para hacer el llamado desde nuestra capa de presentacion
        public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            return objcd_venta.Registrar(obj, DetalleVenta, out Mensaje);
        }

    }

}
