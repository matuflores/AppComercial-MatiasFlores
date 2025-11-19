using AppComercial.Entidades.DTOs.Marca;
using AppComercial.Servicios.Interfaces;
using AppComercial.Windows.Helpers;
using AutoMapper;
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
    public partial class FrmMarcas : Form
    {
        private readonly IMarcaServicio _marcaServicio = null!;
        private readonly IMapper _mapper;
        private List<MarcaListDto> _marcas = new();
        private int cantidadDeRegistros;
        public FrmMarcas(IMarcaServicio marcaServicio, IMapper mapper)
        {
            InitializeComponent();
            _marcaServicio = marcaServicio;
            _mapper = mapper;
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                cantidadDeRegistros = _marcaServicio.ObtenerCantidad();
                _marcas = _marcaServicio.GetMarca();
                MostrarDatosEnGrilla();
                MostrarCantidad();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MostrarCantidad()
        {
            txtCantidad.Text = cantidadDeRegistros.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            foreach (MarcaListDto marca in _marcas)
            {
                var r = GridHelper.ConstruirFila(dgvDatos);

                GridHelper.SetearFila(r, marca);
                GridHelper.AgregarFila(r, dgvDatos);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMarcaAe frm = new FrmMarcaAe() { Text = "NUEVO MARCA" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            MarcaEditDto? marcaEditDto = frm.GetMarca();
            if (marcaEditDto == null) return;
            try
            {
                if (_marcaServicio.Agregar(marcaEditDto, out var errores))
                {
                    MarcaListDto marcaListDto = _mapper.Map<MarcaListDto>(marcaEditDto);
                    DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, marcaListDto);
                    GridHelper.AgregarFila(r, dgvDatos);
                    MessageBox.Show("Marca Agregada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(errores.First(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            MarcaListDto marcaBorrar = (MarcaListDto)r.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea Borrar la marca {marcaBorrar.Descripcion}",
                "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (_marcaServicio.Borrar(marcaBorrar.MarcaId, out var errores))
                {
                    GridHelper.QuitarFila(r, dgvDatos);
                    MessageBox.Show("Marca Eliminada");
                }
                else
                {
                    MessageBox.Show(errores.First(), "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            MarcaListDto? marcaListDto = (MarcaListDto)r.Tag!;
            if (marcaListDto == null) return;
            MarcaEditDto? marcaEditDto = _marcaServicio.GetPorId(marcaListDto.MarcaId);
            if (marcaEditDto is null) return;
            FrmMarcaAe frm = new FrmMarcaAe() { Text = "Editar Marca" };
            frm.SetMarca(marcaEditDto);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            marcaEditDto = frm.GetMarca();
            if (marcaEditDto == null) return;

            try
            {
                if (_marcaServicio.Editar(marcaEditDto, out var errores))
                {
                    marcaListDto = _mapper.Map<MarcaListDto>(marcaEditDto);
                    GridHelper.SetearFila(r, marcaListDto);

                    MessageBox.Show("Marca Modificada", "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(errores.First(), "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
