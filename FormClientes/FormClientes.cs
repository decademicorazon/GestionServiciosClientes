using LibClassModels.Modelos;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Net.Http;


namespace FormClientes
{
    public partial class FormClientes : Form
    {
        private readonly string apiUrl = "http://localhost:5069";
        private readonly HttpClient httpClient = new HttpClient();
        private List<Cliente> listaCliente = new();

        public FormClientes()
        {
            InitializeComponent();
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.MultiSelect = false;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            var datosParaGrid = listaCliente.Select(c => new
            {
                c.Id,
                c.Nombre,
                c.Apellido,
                Tipo = c.TipoCliente
            }).ToList();

            dgvCliente.DataSource = datosParaGrid;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
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


                }
                else
                {
                    MessageBox.Show($"Error al cargar los clientes. C�digo: {(int)response.StatusCode} ({response.StatusCode})");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}");
            }

            dgvCliente.DataSource = null;
            dgvCliente.DataSource = listaCliente;

        }



        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteRequestPost
            {
                id = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Tipo = cmb_tipo.SelectedItem.ToString() // podés cambiar esto si usás un ComboBox para el tipo
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
            // Verificar que se haya seleccionado una fila válida en el DataGridView
            if (dgvCliente.CurrentRow == null || dgvCliente.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, seleccioná un cliente.");
                return;
            }

            // Validar que el ID sea un número entero
            if (!int.TryParse(txtId.Text.Trim(), out int clienteId))
            {
                MessageBox.Show("El ID del cliente no es válido.");
                return;
            }

            // Crear el objeto cliente con los datos del formulario
            var clienteModificado = new Cliente
            {
                Id = clienteId,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim()
            };

            try
            {
                bool resultado = await ModificarCliente(clienteModificado.Id, clienteModificado);

                if (resultado)
                {
                    MessageBox.Show("Cliente actualizado correctamente.");
                    await CargarClientesAsyncs();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
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

        private async Task <bool> ModificarCliente(int id, Cliente cliente)
        {
            using var httpClient = new HttpClient();
            var respuesta = await httpClient.PutAsJsonAsync($"http://localhost:5069/api/Cliente?id={id}", cliente);
            return respuesta.IsSuccessStatusCode;
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null || dgvCliente.CurrentRow.DataBoundItem == null) return;

            var cliente = (Cliente)dgvCliente.CurrentRow.DataBoundItem;

            txtId.Text = cliente.Id.ToString();
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }

    public class ClienteRequestPost
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo { get; set; }

        public List<Servicios>? ServiciosContratados { get; set; } = new List<Servicios>();

        public List<ClienteFactory> clienteFactories { get; set; } = new List<ClienteFactory>();

    }
}