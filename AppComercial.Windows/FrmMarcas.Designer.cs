namespace AppComercial.Windows
{
    partial class FrmMarcas
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
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripButton();
            btnBorrar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCerrar = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            MarcaId = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtCantidad = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnBorrar, btnEditar, toolStripSeparator1, btnCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(912, 67);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.Image = Properties.Resources.Nuevo1;
            btnNuevo.ImageScaling = ToolStripItemImageScaling.None;
            btnNuevo.ImageTransparentColor = Color.Magenta;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(56, 64);
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Image = Properties.Resources.Delete;
            btnBorrar.ImageScaling = ToolStripItemImageScaling.None;
            btnBorrar.ImageTransparentColor = Color.Magenta;
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(54, 64);
            btnBorrar.Text = "Borrar";
            btnBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.Edit;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(52, 64);
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.Click += btnEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 67);
            // 
            // btnCerrar
            // 
            btnCerrar.Image = Properties.Resources.Close;
            btnCerrar.ImageScaling = ToolStripItemImageScaling.None;
            btnCerrar.ImageTransparentColor = Color.Magenta;
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(53, 64);
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 67);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(txtCantidad);
            splitContainer1.Size = new Size(912, 522);
            splitContainer1.SplitterDistance = 414;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 1;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { MarcaId, Marca });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(912, 414);
            dgvDatos.TabIndex = 0;
            // 
            // MarcaId
            // 
            MarcaId.HeaderText = "Id";
            MarcaId.MinimumWidth = 6;
            MarcaId.Name = "MarcaId";
            MarcaId.ReadOnly = true;
            MarcaId.Visible = false;
            MarcaId.Width = 125;
            // 
            // Marca
            // 
            Marca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 36);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(109, 32);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 0;
            // 
            // FrmMarcas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 589);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "FrmMarcas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMarcas";
            Load += FrmMarcas_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnNuevo;
        private ToolStripButton btnBorrar;
        private ToolStripButton btnEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCerrar;
        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn MarcaId;
        private DataGridViewTextBoxColumn Marca;
        private Label label1;
        private TextBox txtCantidad;
    }
}