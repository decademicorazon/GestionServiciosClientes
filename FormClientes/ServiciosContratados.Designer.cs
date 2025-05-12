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
            btn_agregarServicio = new Button();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 38);
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
            dgvServicios.Location = new Point(12, 282);
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
            label3.Location = new Point(168, 485);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 25;
            label3.Text = "Id Cliente:";
            // 
            // txt_IdCliente
            // 
            txt_IdCliente.Location = new Point(243, 482);
            txt_IdCliente.Name = "txt_IdCliente";
            txt_IdCliente.ReadOnly = true;
            txt_IdCliente.Size = new Size(149, 23);
            txt_IdCliente.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(413, 485);
            label1.Name = "label1";
            label1.Size = new Size(79, 18);
            label1.TabIndex = 27;
            label1.Text = "Id servicio:";
            // 
            // txt_IdServicio
            // 
            txt_IdServicio.Location = new Point(496, 482);
            txt_IdServicio.Name = "txt_IdServicio";
            txt_IdServicio.ReadOnly = true;
            txt_IdServicio.Size = new Size(149, 23);
            txt_IdServicio.TabIndex = 26;
            // 
            // btn_agregarServicio
            // 
            btn_agregarServicio.BackColor = Color.Lime;
            btn_agregarServicio.FlatStyle = FlatStyle.Flat;
            btn_agregarServicio.ForeColor = SystemColors.ActiveCaptionText;
            btn_agregarServicio.Location = new Point(336, 548);
            btn_agregarServicio.Name = "btn_agregarServicio";
            btn_agregarServicio.Size = new Size(121, 34);
            btn_agregarServicio.TabIndex = 28;
            btn_agregarServicio.Text = "AGREGAR SERVICIO";
            btn_agregarServicio.UseVisualStyleBackColor = false;
            btn_agregarServicio.Click += btn_agregarServicio_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(62, 18);
            label2.TabIndex = 29;
            label2.Text = "Clientes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 252);
            label4.Name = "label4";
            label4.Size = new Size(68, 18);
            label4.TabIndex = 30;
            label4.Text = "Servicios:";
            // 
            // ServiciosContratados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 594);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btn_agregarServicio);
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
        private Button btn_agregarServicio;
        private Label label2;
        private Label label4;
    }
}