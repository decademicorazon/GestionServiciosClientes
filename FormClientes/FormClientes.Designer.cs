namespace FormClientes
{
    partial class FormClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCliente = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtId = new TextBox();
            btn_agregar = new Button();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            btn_limpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvCliente
            // 
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(12, 100);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.Size = new Size(734, 185);
            dgvCliente.TabIndex = 0;
            dgvCliente.SelectionChanged += dgvAlumnos_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 63);
            label1.Name = "label1";
            label1.Size = new Size(65, 18);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(526, 63);
            label2.Name = "label2";
            label2.Size = new Size(60, 18);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 63);
            label3.Name = "label3";
            label3.Size = new Size(27, 18);
            label3.TabIndex = 4;
            label3.Text = "Id:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(322, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(597, 63);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(149, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(47, 61);
            txtId.Name = "txtId";
            txtId.Size = new Size(149, 23);
            txtId.TabIndex = 8;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(769, 100);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(99, 42);
            btn_agregar.TabIndex = 9;
            btn_agregar.Text = "AGREGAR";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btnAgregar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(769, 169);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(99, 42);
            btn_modificar.TabIndex = 10;
            btn_modificar.Text = "MODIFICAR";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btnActualizar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(769, 243);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(99, 42);
            btn_eliminar.TabIndex = 11;
            btn_eliminar.Text = "ELIMINAR";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btnEliminar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(346, 12);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(99, 26);
            btn_limpiar.TabIndex = 12;
            btn_limpiar.Text = "LIMPIAR";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 330);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_agregar);
            Controls.Add(txtId);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCliente);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtId;
        private Button btn_agregar;
        private Button btn_modificar;
        private Button btn_eliminar;
        private Button btn_limpiar;
    }
}
