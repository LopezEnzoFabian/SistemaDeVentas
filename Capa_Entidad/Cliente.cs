using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Cliente
    {
        public int Id_cliente {  get; set; }
        public string DNI {  get; set; }
        public string Nombre_completo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion {  get; set; }
        public string Ciudad { get; set; }
        public string Codigo_postal { get; set; }
        public bool Estado {  get; set; }
        public string Fecha_registro { get; set; }

    }
}
