using LibClassModels.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClientes
{
    public partial class FormServicio : Form
    {

        private readonly HttpClient httpClient = new HttpClient();
        private List<Servicios> listaServicios = new();

        public FormServicio()
        {
            InitializeComponent();
        }

        private async Task CargarServicios()
        {
            try
            {
                var response = await httpClient.GetAsync("http://localhost:5069/api/Servicios");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    listaServicios = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Servicios>>(json, new Newtonsoft.Json.JsonSerializerSettings
                    {
                        TypeNameHandling = Newtonsoft.Json.TypeNameHandling.All
                    });
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarBotones();
        }
        private void LimpiarBotones()
        {
            txtIdServicio.Clear();
            txtNombreServicio.Clear();
            txtPrecioServicio.Clear();
        }
        private async void FormServicio_Load(object sender, EventArgs e)
        {
            await CargarServicios();
        }

        private void dgvServicios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServicios.CurrentRow == null || dgvServicios.CurrentRow.DataBoundItem == null) return;

            var servicio = (Servicios)dgvServicios.CurrentRow.DataBoundItem;
            txtIdServicio.Text = servicio.Id.ToString();
            txtNombreServicio.Text = servicio.Nombre;
            txtPrecioServicio.Text = servicio.Precio.ToString();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var Servicios = new Servicios
            {
                Id = Convert.ToInt32(txtIdServicio.Text),
                Nombre = txtNombreServicio.Text,
                Precio = Convert.ToDecimal(txtPrecioServicio.Text)
            };

            var json = JsonConvert.SerializeObject(Servicios);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = httpClient.PostAsync("http://localhost:5069/api/Servicios", content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Servicio agregado correctamente");
                CargarServicios();
            }
            else
            {
                MessageBox.Show("Error al agregar el servicio");
            }

        }

        private async void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgvServicios.CurrentRow == null) return;

            var servicioModificado = new Servicios
            {
                Id = Convert.ToInt32(txtIdServicio.Text),
                Nombre = txtNombreServicio.Text,
                Precio = Convert.ToDecimal(txtPrecioServicio.Text)
            };

            bool resultado = await ModificarServicios(servicioModificado.Id, servicioModificado);

            if (resultado)
            {
                MessageBox.Show("Servicio modificado correctamente");
                await CargarServicios();
            }
            else
            {
                MessageBox.Show("Error al modificar el servicio");
            }
        }

        private async Task<bool> ModificarServicios(int id, Servicios servicio)
        {
            var json = JsonConvert.SerializeObject(servicio);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"http://localhost:5069/api/Servicios?id={id}", content);
            return response.IsSuccessStatusCode;
        }

        private async void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgvServicios.CurrentRow == null) return;
            var servicio = (Servicios)dgvServicios.CurrentRow.DataBoundItem;
            var response = await httpClient.DeleteAsync($"http://localhost:5069/api/Servicios?id={servicio.Id}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Servicio eliminado correctamente");
                LimpiarBotones();
                await CargarServicios();
                


            }
            else
            {
                MessageBox.Show("Error al eliminar el servicio");
            }

        }
    }

    public class Servicios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }


    }
}
