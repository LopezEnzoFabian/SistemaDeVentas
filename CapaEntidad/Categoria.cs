using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
   public class Categoria
    {
        public int Id_categoria {  get; set; } 
        public string Descripcion { get; set; }
        public bool Estado {  get; set; }
        public string Fecha_registro { get; set; }
    }
}
