﻿using Capa_Entidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_compras
    {
        private CD_compras oCD_compras = new CD_compras();
        public int OptenerCorrelativo()
        {
            return oCD_compras.OptenerCorrelativo();
        }

        //metodos para hacer el llamado desde nuestra capa de presentacion
        public bool Registrar(Compra obj,DataTable DetalleCompra, out string Mensaje)
        {
            return oCD_compras.Registrar(obj,DetalleCompra, out Mensaje);
        }

        public Compra SeleccionarCompra(string num) { 

           Compra Ocompra = oCD_compras.SeleccionarCompra(num);

            if(Ocompra.Id_compra != 0)
            {
                List<Detalle_compra> oDetalle_compra = oCD_compras.SeleccionarDetalleCompra(Ocompra.Id_compra);
                
                Ocompra.oDetalle_compra = oDetalle_compra;      
            }
            return Ocompra;
        }
    }
}
