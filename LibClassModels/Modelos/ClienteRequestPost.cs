using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClassModels.Modelos
{
    public class ClienteRequestPost
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo { get; set; } // Este campo indica si es "frecuente", "operativo" o "normal"
    }

}
