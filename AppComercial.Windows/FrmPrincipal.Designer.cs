namespace AppComercial.Windows
{
    partial class FrmPrincipal
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
            btnMarcas = new Button();
            btnProductos = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnMarcas
            // 
            btnMarcas.Location = new Point(51, 52);
            btnMarcas.Margin = new Padding(3, 4, 3, 4);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Size = new Size(107, 72);
            btnMarcas.TabIndex = 0;
            btnMarcas.Text = "Marcas";
            btnMarcas.UseVisualStyleBackColor = true;
            btnMarcas.Click += btnMarcas_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(205, 52);
            btnProductos.Margin = new Padding(3, 4, 3, 4);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(107, 72);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(795, 509);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 60);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSalir);
            Controls.Add(btnProductos);
            Controls.Add(btnMarcas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMarcas;
        private Button btnProductos;
        private Button btnSalir;
    }
}