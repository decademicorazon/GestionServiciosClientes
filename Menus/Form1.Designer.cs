namespace Menus
{
    partial class MenuPrincipal
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
            btn_contratar = new Button();
            btn_servicios = new Button();
            btn_clientes = new Button();
            SuspendLayout();
            // 
            // btn_contratar
            // 
            btn_contratar.Location = new Point(118, 248);
            btn_contratar.Name = "btn_contratar";
            btn_contratar.Size = new Size(111, 62);
            btn_contratar.TabIndex = 5;
            btn_contratar.Text = "CONTRATAR";
            btn_contratar.UseVisualStyleBackColor = true;
            btn_contratar.Click += btn_contratar_Click;
            // 
            // btn_servicios
            // 
            btn_servicios.Location = new Point(118, 149);
            btn_servicios.Name = "btn_servicios";
            btn_servicios.Size = new Size(111, 62);
            btn_servicios.TabIndex = 4;
            btn_servicios.Text = "SERVICIOS";
            btn_servicios.UseVisualStyleBackColor = true;
            btn_servicios.Click += btn_servicios_Click;
            // 
            // btn_clientes
            // 
            btn_clientes.Location = new Point(118, 56);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(111, 62);
            btn_clientes.TabIndex = 3;
            btn_clientes.Text = "CLIENTES";
            btn_clientes.UseVisualStyleBackColor = true;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 399);
            Controls.Add(btn_contratar);
            Controls.Add(btn_servicios);
            Controls.Add(btn_clientes);
            Name = "MenuPrincipal";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_contratar;
        private Button btn_servicios;
        private Button btn_clientes;
    }
}
