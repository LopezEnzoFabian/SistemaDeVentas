using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Detalle_venta
    {
        public int Id_detalle_venta {  get; set; }
        public Producto oProducto { get; set; }
        public decimal Precio_venta { get; set; }
        public int Cantidad {  get; set; }
        public decimal Sub_total { get; set; }
        public string Fecha_registro { get; set; }

    }
}
