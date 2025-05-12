using LibClassModels.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClientes
{
    public partial class ServiciosContratados : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        private List<Servicios> listaServicios = new();
        private List<Cliente> listaCliente = new();
        public ServiciosContratados()
        {
            InitializeComponent();
        }

        private async void ServiciosContratados_Load(object sender, EventArgs e)
        {
            await CargarClientesAsyncs();
            await CargarServiciosAsyncs();
        }
        private async Task CargarServiciosAsyncs()
        {
            try
            {
                var response = await httpClient.GetAsync("http://localhost:5069/api/Servicios");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    listaServicios = JsonConvert.DeserializeObject<List<Servicios>>(json);
                    dgvServicios.DataSource = listaServicios;
                }
                else
                {
                    MessageBox.Show($"Error al cargar los servicios. Código: {(int)response.StatusCode} ({response.StatusCode})");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los servicios: {ex.Message}");
            }
        }

        private async Task<bool> ContratarServicios(int idCliente, int idServicios)
        {

            using var httpClient = new HttpClient();
            var respuesta = await httpClient.PostAsJsonAsync($"http://localhost:5069/api/Cliente/AgregarServicio/?idCliente={idCliente}", idServicios);
            return respuesta.IsSuccessStatusCode;

        }




        private async Task CargarClientesAsyncs()
        {
            try
            {
                var response = await httpClient.GetAsync($"http://localhost:5069/api/Cliente");

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
                    MessageBox.Show($"Error al cargar los clientes. Código: {(int)response.StatusCode} ({response.StatusCode})");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}");
            }

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaCliente;

        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la fila clickeada sea válida
            if (e.RowIndex >= 0 && dgvClientes.Rows[e.RowIndex].Cells[0].Value != null)
            {
                var idCliente = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value);

                txt_IdCliente.Text = idCliente.ToString();
            }


        }

        private void dgvServicios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvServicios.Rows[e.RowIndex].Cells[0].Value != null)
            {
                var idServicio = Convert.ToInt32(dgvServicios.Rows[e.RowIndex].Cells[0].Value);
                txt_IdServicio.Text = idServicio.ToString();
            }
        }

        private async void btn_agregarServicio_Click(object sender, EventArgs e)
        {
            int idcliente = int.Parse(txt_IdCliente.Text);
            int idservicio = int.Parse(txt_IdServicio.Text);

            bool exito = await ContratarServicios(idcliente, idservicio);

            if (exito)
            {
                MessageBox.Show("Servicio contratado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al contratar el servicio.");
            }
        }
    }
}
