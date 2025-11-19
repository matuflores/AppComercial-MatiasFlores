using AppComercial.Ioc;
using AppComercial.Servicios.Interfaces;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            IMarcaServicio servicio=DI.ServiceProvider!
                .GetRequiredService<IMarcaServicio>();
            IMapper mapper=DI.ServiceProvider!
                .GetRequiredService<IMapper>();
            FrmMarcas frm=new FrmMarcas(servicio, mapper) { Text="LISTADO DE MARCAS"}; 
            frm.ShowDialog();
        }
    }
}
