namespace FormClientes
{
    partial class ServiciosContratados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvClientes = new DataGridView();
            dgvServicios = new DataGridView();
            label3 = new Label();
            txt_IdCliente = new TextBox();
            label1 = new Label();
            txt_IdServicio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 12);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(776, 197);
            dgvClientes.TabIndex = 14;
            dgvClientes.CellContentDoubleClick += dgvClientes_CellContentDoubleClick;
            // 
            // dgvServicios
            // 
            dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServicios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(12, 233);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.ReadOnly = true;
            dgvServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicios.Size = new Size(776, 185);
            dgvServicios.TabIndex = 15;
            dgvServicios.CellContentDoubleClick += dgvServicios_CellContentDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(164, 434);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 25;
            label3.Text = "Id Cliente:";
            // 
            // txt_IdCliente
            // 
            txt_IdCliente.Location = new Point(239, 431);
            txt_IdCliente.Name = "txt_IdCliente";
            txt_IdCliente.ReadOnly = true;
            txt_IdCliente.Size = new Size(149, 23);
            txt_IdCliente.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 434);
            label1.Name = "label1";
            label1.Size = new Size(79, 18);
            label1.TabIndex = 27;
            label1.Text = "Id servicio:";
            // 
            // txt_IdServicio
            // 
            txt_IdServicio.Location = new Point(492, 431);
            txt_IdServicio.Name = "txt_IdServicio";
            txt_IdServicio.ReadOnly = true;
            txt_IdServicio.Size = new Size(149, 23);
            txt_IdServicio.TabIndex = 26;
            // 
            // ServiciosContratados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 477);
            Controls.Add(label1);
            Controls.Add(txt_IdServicio);
            Controls.Add(label3);
            Controls.Add(txt_IdCliente);
            Controls.Add(dgvServicios);
            Controls.Add(dgvClientes);
            Name = "ServiciosContratados";
            Text = "ServiciosContratados";
            Load += ServiciosContratados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private DataGridView dgvServicios;
        private Label label3;
        private TextBox txt_IdCliente;
        private Label label1;
        private TextBox txt_IdServicio;
    }
}