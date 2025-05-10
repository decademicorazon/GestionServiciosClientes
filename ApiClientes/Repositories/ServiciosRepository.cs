using LibClassModels.Modelos;
using System.Text.Json;

namespace ApiClientes.Repositories
{
    public class ServiciosRepository
    {

        private readonly string archivoJson = "servicios.json";
        private List<Servicios> servicios = new List<Servicios>();

        public ServiciosRepository()
        {
            if (File.Exists(archivoJson))
            {
                var json = File.ReadAllText(archivoJson);
                servicios = JsonSerializer.Deserialize<List<Servicios>>(json);
            }
        }

        public void AgregarServicio(Servicios servicio)
        {
            servicios.Add(servicio);
            GuardarServicios();
        }
        public List<Servicios> ObtenerServicios()
        {
            return servicios;
        }

        public Servicios ObtenerServicioPorId(int id)
        {
            var servicio = servicios.FirstOrDefault(c => c.Id == id);
            return servicio;

        }

        public Servicios ActualizarServicio(int id ,Servicios servicio)
        {
            var ServicioExistente = servicios.FirstOrDefault(c => c.Id == id);
            if (ServicioExistente == null)
            {
                return null;
            }
            ServicioExistente.Nombre = servicio.Nombre;
            ServicioExistente.Precio = servicio.Precio;

            GuardarServicios();
            return ServicioExistente;
        }

        public void EliminarServicio(int id)
        {
            var servicio = servicios.FirstOrDefault(c => c.Id == id);
            servicios.Remove(servicio);
            GuardarServicios();
        }


        public void GuardarServicios()
        {
            var json = JsonSerializer.Serialize(servicios);
            File.WriteAllText(archivoJson, json);
        }
    }
}
