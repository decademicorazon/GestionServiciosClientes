using LibClassModels.Modelos;
using Newtonsoft.Json;
using System.Text.Json;

namespace ApiClientes.Repositories
{
    public class ClienteRepository
    {
        private readonly ServiciosRepository serviciosRepository = new ServiciosRepository();
        private readonly string Json = "clientes.json";
        private List<Cliente> clientes;

        public ClienteRepository()
        {
            
            clientes = CargarDeJson<Cliente>(Json);
        }


        public Cliente ObtenerClientePorId(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id);
            return cliente;

        }

        public Cliente ContratarServicio (int idCliente, int idServicio)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == idCliente);
            var servicio = serviciosRepository.ObtenerServicioPorId(idServicio);
            if (cliente == null )
            { return null; }

            if (servicio == null)
            { return null; }
            var servicioConDescuento = new Servicios
            {

                Id = servicio.Id,
                Nombre = servicio.Nombre,
                Precio = cliente.AplicarDescuento(servicio.Precio)
            };

            Console.WriteLine(cliente.GetType().Name);

            cliente.ServiciosContratados.Add(servicioConDescuento);
            

            GuardarClientes();
            return cliente;

        }
        
        

        
        public void AgregarCliente(ClienteRequestPost clientePost)
        {

            var cliente = ClienteFactory.CrearCliente(clientePost.Tipo);

            cliente.Id = clientePost.id;
            cliente.Nombre = clientePost.Nombre;
            cliente.Apellido = clientePost.Apellido;
            
            clientes.Add(cliente);
            GuardarClientes();
        }

        public IEnumerable<Cliente> ObtenerClientes()
        {
            return clientes;
        }




        public Cliente ActualizarCliente(int id,Cliente cliente)
        {
            var ClienteExistente = clientes.FirstOrDefault(c => c.Id == id);
            if(ClienteExistente == null)
            {
                
                return null;
            }
            ClienteExistente.Nombre = cliente.Nombre;
            ClienteExistente.Apellido = cliente.Apellido;
            GuardarClientes();
            return ClienteExistente;
           

        }

        public void EliminarCliente(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id);
            clientes.Remove(cliente);
            GuardarClientes();
        }










        public static List<T> CargarDeJson<T>(string archivo)
        {
            if (!File.Exists(archivo)) return new List<T>();
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            string json = File.ReadAllText(archivo);
            try
            {
                return JsonConvert.DeserializeObject<List<T>>(json,settings);
            }
            catch (System.Text.Json.JsonException ex)
            {
                Console.WriteLine($"Error al deserializar el archivo JSON: {ex.Message}");
                return new List<T>();
            }
        }
            public void GuardarClientes()
            {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            var json = JsonConvert.SerializeObject(clientes,settings);
                File.WriteAllText(Json, json);
            }
        }
    } 
