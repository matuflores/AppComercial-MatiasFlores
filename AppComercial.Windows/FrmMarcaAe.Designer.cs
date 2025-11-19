namespace AppComercial.Windows
{
    partial class FrmMarcaAe
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
            components = new System.ComponentModel.Container();
            btnOKMarcaAE = new Button();
            button2 = new Button();
            errorProviderMarcaAe = new ErrorProvider(components);
            label1 = new Label();
            textBoxMarcaAE = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProviderMarcaAe).BeginInit();
            SuspendLayout();
            // 
            // btnOKMarcaAE
            // 
            btnOKMarcaAE.Location = new Point(51, 165);
            btnOKMarcaAE.Margin = new Padding(3, 4, 3, 4);
            btnOKMarcaAE.Name = "btnOKMarcaAE";
            btnOKMarcaAE.Size = new Size(86, 69);
            btnOKMarcaAE.TabIndex = 0;
            btnOKMarcaAE.Text = "OK";
            btnOKMarcaAE.UseVisualStyleBackColor = true;
            btnOKMarcaAE.Click += btnOKMarcaAE_Click;
            // 
            // button2
            // 
            button2.Location = new Point(415, 165);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 69);
            button2.TabIndex = 0;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // errorProviderMarcaAe
            // 
            errorProviderMarcaAe.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 76);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Marca:";
            // 
            // textBoxMarcaAE
            // 
            textBoxMarcaAE.Location = new Point(104, 73);
            textBoxMarcaAE.Margin = new Padding(3, 4, 3, 4);
            textBoxMarcaAE.MaxLength = 50;
            textBoxMarcaAE.Name = "textBoxMarcaAE";
            textBoxMarcaAE.Size = new Size(382, 27);
            textBoxMarcaAE.TabIndex = 2;
            // 
            // FrmMarcaAe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 256);
            Controls.Add(textBoxMarcaAE);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnOKMarcaAE);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(577, 303);
            MinimumSize = new Size(577, 303);
            Name = "FrmMarcaAe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMarcaAe";
            ((System.ComponentModel.ISupportInitialize)errorProviderMarcaAe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOKMarcaAE;
        private Button button2;
        private ErrorProvider errorProviderMarcaAe;
        private TextBox textBoxMarcaAE;
        private Label label1;
    }
}