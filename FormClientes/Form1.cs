using LibClassModels.Modelos;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace FormClientes
{
    public partial class Form1 : Form
    {
        private readonly string apiUrl = "http://localhost:5069";
        private readonly HttpClient httpClient = new HttpClient();
        private List<Cliente> listaCliente = new();

        public Form1()
        {
            InitializeComponent();
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.MultiSelect = false;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarClientesAsyncs();
        }

        private async Task CargarClientesAsyncs()
        {
            try
            {
                var response = await httpClient.GetAsync($"{apiUrl}/api/Cliente");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    // Usar Newtonsoft para manejar herencia
                    listaCliente = JsonConvert.DeserializeObject<List<Cliente>>(json, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    });

                    dgvCliente.AutoGenerateColumns = true;
                    dgvCliente.DataSource = listaCliente.Select(c => new
                    {
                        c.Id,
                        c.Nombre,
                        c.Apellido,
                        Tipo = c.GetType().Name
                    }).ToList();
                }
                else
                {
                    MessageBox.Show($"Error al cargar los clientes. Código: {(int)response.StatusCode} ({response.StatusCode})");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}");
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteRequestPost
            {
                id = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Tipo = "Frecuente" // podés cambiar esto si usás un ComboBox para el tipo
            };

            var json = JsonConvert.SerializeObject(cliente);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync($"{apiUrl}/api/Cliente", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cliente agregado correctamente");
                await CargarClientesAsyncs();
            }
            else
            {
                MessageBox.Show("Error al agregar el cliente");
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null) return;

            var cliente = listaCliente[dgvCliente.CurrentRow.Index];
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;

            var json = JsonConvert.SerializeObject(cliente, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{apiUrl}/api/Cliente/{cliente.Id}", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cliente actualizado correctamente");
                await CargarClientesAsyncs();
            }
            else
            {
                MessageBox.Show("Error al actualizar el cliente");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null) return;

            var cliente = listaCliente[dgvCliente.CurrentRow.Index];
            var response = await httpClient.DeleteAsync($"{apiUrl}/api/Cliente/{cliente.Id}");

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cliente eliminado correctamente");
                await CargarClientesAsyncs();
            }
            else
            {
                MessageBox.Show("Error al eliminar el cliente");
            }
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null || listaCliente.Count == 0) return;

            var cliente = listaCliente[dgvCliente.CurrentRow.Index];

            txtId.Text = cliente.Id.ToString();
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
        }
    }

    public class ClienteRequestPost
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo { get; set; }
    }
}