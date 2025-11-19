namespace AppComercial.Windows
{
    partial class FrmFiltro
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
            txtMarca = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(113, 62);
            txtMarca.MaxLength = 50;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(335, 23);
            txtMarca.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 64);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Marca:";
            // 
            // button2
            // 
            button2.Location = new Point(385, 131);
            button2.Name = "button2";
            button2.Size = new Size(75, 52);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(67, 131);
            button1.Name = "button1";
            button1.Size = new Size(75, 52);
            button1.TabIndex = 4;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 219);
            Controls.Add(txtMarca);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(546, 258);
            MinimumSize = new Size(546, 258);
            Name = "FrmFiltro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFiltro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarca;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}