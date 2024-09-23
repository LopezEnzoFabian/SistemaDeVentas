using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Permiso
    {
        public int Id_permiso {  get; set; }
        public Rol oRol { get; set; }
        public string NombreMenu { get; set; }
        public string Fecha_registro { get; set; }
    }
}
