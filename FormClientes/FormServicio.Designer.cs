namespace FormClientes
{
    partial class FormServicio
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
            btn_limpiar = new Button();
            btn_eliminar = new Button();
            btn_modificar = new Button();
            btn_agregar = new Button();
            txtIdServicio = new TextBox();
            txtPrecioServicio = new TextBox();
            txtNombreServicio = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvServicios = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            SuspendLayout();
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(305, 12);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(99, 26);
            btn_limpiar.TabIndex = 22;
            btn_limpiar.Text = "LIMPIAR";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(729, 320);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(99, 42);
            btn_eliminar.TabIndex = 21;
            btn_eliminar.Text = "ELIMINAR";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(729, 246);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(99, 42);
            btn_modificar.TabIndex = 20;
            btn_modificar.Text = "MODIFICAR";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(729, 177);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(99, 42);
            btn_agregar.TabIndex = 19;
            btn_agregar.Text = "AGREGAR";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // txtIdServicio
            // 
            txtIdServicio.Location = new Point(45, 145);
            txtIdServicio.Name = "txtIdServicio";
            txtIdServicio.Size = new Size(149, 23);
            txtIdServicio.TabIndex = 18;
            // 
            // txtPrecioServicio
            // 
            txtPrecioServicio.Location = new Point(557, 145);
            txtPrecioServicio.Name = "txtPrecioServicio";
            txtPrecioServicio.Size = new Size(149, 23);
            txtPrecioServicio.TabIndex = 17;
            // 
            // txtNombreServicio
            // 
            txtNombreServicio.Location = new Point(305, 143);
            txtNombreServicio.Name = "txtNombreServicio";
            txtNombreServicio.Size = new Size(149, 23);
            txtNombreServicio.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(500, 148);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 15;
            label2.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 145);
            label1.Name = "label1";
            label1.Size = new Size(65, 18);
            label1.TabIndex = 14;
            label1.Text = "Nombre:";
            // 
            // dgvServicios
            // 
            dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServicios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(10, 177);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.ReadOnly = true;
            dgvServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicios.Size = new Size(713, 185);
            dgvServicios.TabIndex = 13;
            dgvServicios.SelectionChanged += dgvServicios_SelectionChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(27, 18);
            label3.TabIndex = 23;
            label3.Text = "Id:";
            // 
            // FormServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 399);
            Controls.Add(label3);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_agregar);
            Controls.Add(txtIdServicio);
            Controls.Add(txtPrecioServicio);
            Controls.Add(txtNombreServicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvServicios);
            Name = "FormServicio";
            Text = "FormServicio";
            Load += FormServicio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_limpiar;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_agregar;
        private TextBox txtIdServicio;
        private TextBox txtPrecioServicio;
        private TextBox txtNombreServicio;
        private Label label2;
        private Label label1;
        private DataGridView dgvServicios;
        private Label label3;
    }
}