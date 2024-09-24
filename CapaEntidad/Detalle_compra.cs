using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Detalle_compra
    {
        public int Id_detalle_compra { get; set; }
        public Producto oProducto { get; set; }
        public decimal Precio_compra { get; set; }
        public decimal Precio_venta {  get; set; }
        public int Cantidad {  get; set; }
        public decimal Monto_total { get; set; }
        public string Fecha_registro { get; set; }

    }
}
