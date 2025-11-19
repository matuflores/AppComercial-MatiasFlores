using AppComercial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppComercial.Datos.Interfaces
{
    public interface IMarcaRepositorio
    {
        void Agregar(Marca marca);
        void Borrar(int marcaId);
        void Editar(Marca marca);
        bool Existe(Marca marca);
        List<Marca> GetPais(string? textoParaFiltrar = null);
        Marca? GetPorId(int marcaId);

        int GetCantidad();
    }
}
