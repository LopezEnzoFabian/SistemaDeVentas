using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Usuario
    {
        public int Id_usuario {  get; set; }
        public string DNI { get; set; }
        public string Nombre_completo { get; set; }
        public string Email {  get; set; }
        public string Pass {  get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public Rol oRol { get; set; }
        public bool Estado { get; set; }
        public string Fecha_registro { get; set; }

    }
}
