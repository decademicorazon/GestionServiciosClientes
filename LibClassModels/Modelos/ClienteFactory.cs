using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClassModels.Modelos
{
    public class ClienteFactory
    {

        public static Cliente CrearCliente(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "frecuente":
                    return new ClienteFrecuente();
                case "operativo":
                    return new ClienteOperativo();
                default:
                    return new Cliente(); // normal
            }
        }
    }
}
