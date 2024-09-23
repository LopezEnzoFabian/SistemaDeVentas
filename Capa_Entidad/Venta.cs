using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Venta
    {
        public int Id_venta {  get; set; }
        public Usuario oUsuario { get; set; }
        public string Tipo_factura { get; set; }
        public string Numero_factura { get; set; }
        public string DNI_cliente { get; set; }
        public string Nombre_cliente { get; set; }
        public decimal Monto_pago { get; set; }
        public decimal Monto_cambio { get; set; }
        public decimal Monto_total { get; set; }
        public string Fecha_registro { get; set; }
        public List<Detalle_venta> oDetalle_venta { get; set; }
    }
}
