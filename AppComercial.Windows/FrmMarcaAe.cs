using AppComercial.Entidades.DTOs.Marca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComercial.Windows
{
    public partial class FrmMarcaAe : Form
    {
        private MarcaEditDto? marca;
        public FrmMarcaAe()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (marca is not null)
            {
                textBoxMarcaAE.Text = marca.Descripcion;
            }
        }

        public MarcaEditDto? GetMarca()
        {
            return marca;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOKMarcaAE_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (marca == null)
                {
                    marca = new MarcaEditDto();
                }
                marca.Descripcion = textBoxMarcaAE.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProviderMarcaAe.Clear();
            if (string.IsNullOrEmpty(textBoxMarcaAE.Text))
            {
                valido = false;
                errorProviderMarcaAe.SetError(textBoxMarcaAE, "DESCRIPCION DE MARCA REQUERIDA");
            }
            return valido;
        }

        public void SetMarca(MarcaEditDto marca)
        {
            this.marca = marca;
        }
    }
}
