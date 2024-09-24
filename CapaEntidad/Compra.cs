using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Compra
    {
        public int Id_compra {  get; set; }
        public Usuario oUsuario { get; set; }
        public Porveedor oProveedor { get; set; }
        public string Tipo_factura { get; set; }
        public string Numero_factura { get; set; }
        public  decimal Monto_total { get; set; }
        public string Fecha_registro { get; set; }
        public List<Detalle_compra> oDetalle_compra { get; set; }

    }
}
