

using FormClientes;

namespace Menus
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            // Ensure FormClientes is a class and not just a namespace
            FormClientes.FormClientes formClientes = new FormClientes.FormClientes();
            formClientes.Show();
            this.Hide();
        }

        private void btn_servicios_Click(object sender, EventArgs e)
        {
            // Ensure FormServicio is correctly defined and accessible
            FormServicio servicios = new FormServicio();
            servicios.Show();
            this.Hide();
        }

        private void btn_contratar_Click(object sender, EventArgs e)
        {
            ServiciosContratados servis = new ServiciosContratados();
            servis.Show();
            this.Hide();
        }
    }
}
