namespace AppComercial.Windows
{
    partial class FrmProductos
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
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            label1 = new Label();
            txtCantidad = new TextBox();
            toolStrip1 = new ToolStrip();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbCerrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            colMarcaId = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            colPrecioCompra = new DataGridViewTextBoxColumn();
            colPrecioVenta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 62);
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
            splitContainer1.Size = new Size(1015, 388);
            splitContainer1.SplitterDistance = 308;
            splitContainer1.TabIndex = 3;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colMarcaId, Descripcion, colMarca, colPrecioCompra, colPrecioVenta });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.Size = new Size(1015, 308);
            dgvDatos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(95, 24);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbEditar, tsbActualizar, toolStripSeparator1, tsbCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1015, 62);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.filter_40px;
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(44, 59);
            tsbEditar.Text = "Filtrar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // tsbCerrar
            // 
            tsbCerrar.Image = Properties.Resources.Close;
            tsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbCerrar.ImageTransparentColor = Color.Magenta;
            tsbCerrar.Name = "tsbCerrar";
            tsbCerrar.Size = new Size(44, 59);
            tsbCerrar.Text = "Cerrar";
            tsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.Update;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 59);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // colMarcaId
            // 
            colMarcaId.HeaderText = "Id";
            colMarcaId.Name = "colMarcaId";
            colMarcaId.ReadOnly = true;
            colMarcaId.Visible = false;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // colMarca
            // 
            colMarca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMarca.HeaderText = "Marca";
            colMarca.Name = "colMarca";
            colMarca.ReadOnly = true;
            // 
            // colPrecioCompra
            // 
            colPrecioCompra.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPrecioCompra.HeaderText = "P. Compra";
            colPrecioCompra.Name = "colPrecioCompra";
            colPrecioCompra.ReadOnly = true;
            colPrecioCompra.Width = 88;
            // 
            // colPrecioVenta
            // 
            colPrecioVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPrecioVenta.HeaderText = "P. Vta.";
            colPrecioVenta.Name = "colPrecioVenta";
            colPrecioVenta.ReadOnly = true;
            colPrecioVenta.Width = 65;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "FrmProductos";
            Text = "FrmProductos";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private Label label1;
        private TextBox txtCantidad;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbCerrar;
        private DataGridViewTextBoxColumn colMarcaId;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colPrecioCompra;
        private DataGridViewTextBoxColumn colPrecioVenta;
        private ToolStripButton tsbActualizar;
    }
}