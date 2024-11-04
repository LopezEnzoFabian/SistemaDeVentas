using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Reporte_venta
    {
        public string Fecha_registro { get; set; }
        public string Tipo_factura { get; set; }
        public string Numero_factura { get; set; }
        public string Monto_total { get; set; }
        public string Usuario_registro { get; set; }
        public string Dni_cliente{ get; set; }
        public string Nombre_cliente { get; set; }
        public string Codigo_producto { get; set; }
        public string Nombre_producto { get; set; }
        public string Categoria { get; set; }
        public string Precio_venta { get; set; }
        public string Cantidad { get; set; }
        public string Subtotal { get; set; }
    }
}
