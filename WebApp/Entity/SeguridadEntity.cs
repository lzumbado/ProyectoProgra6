using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SeguridadEntity:DBEntity
    {
        public int? IdSeguridad { get; set; }
        public string NombreUsuario { get; set; }

        public string Usuario { get; set; }
        public string Contrasena { get; set; }


    }
}
