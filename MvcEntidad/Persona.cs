using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcEntidad
{
    public class Persona
    {        
        public long Id { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string NombreCompleto { get; set; }
        public string TelefonoContacto { get; set; }
        public string Direccion { get; set; }
        public bool Proveedor { get; set; }
    }
}
