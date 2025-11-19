using AppComercial.Entidades;
using AppComercial.Entidades.DTOs.Marca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppComercial.Servicios.Interfaces
{
    public interface IMarcaServicio
    {
        bool Borrar(int marcaId, out List<string> errores);
        bool Existe(Marca marca);
        List<MarcaListDto> GetMarca(string? textoParaFiltrar = null);
        bool Agregar(MarcaEditDto marcaDto, out List<string> errores);
        bool Editar(MarcaEditDto marcaDto, out List<string> errores);
        MarcaEditDto? GetPorId(int marcaId);

        int ObtenerCantidad();
    }
}
