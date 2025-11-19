using AppComercial.Datos.Interfaces;
using AppComercial.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppComercial.Datos.Repositorios
{
    public class MarcaRepositorio : IMarcaRepositorio
    {
        private readonly ComercialDbContext? _dbContext;
        public MarcaRepositorio(ComercialDbContext? dbContext)
        {
            _dbContext = dbContext;
        }
        public void Agregar(Marca marca)
        {
            _dbContext.Marcas.Add(marca);
            _dbContext.SaveChanges();
        }

        public void Borrar(int marcaId)
        {
            var marcaInDb = _dbContext.Marcas.Find(marcaId);
            if (marcaInDb == null) return;
            _dbContext.Marcas.Remove(marcaInDb);
            _dbContext.ChangeTracker.Entries().ToList();
            _dbContext.SaveChanges();
        }

        public void Editar(Marca marca)
        {
            var marcaInDb = _dbContext.Marcas.Find(marca.MarcaId);
            if (marcaInDb == null) return;
            marcaInDb.Descripcion = marca.Descripcion;
            _dbContext.ChangeTracker.Entries().ToList();
            _dbContext.SaveChanges();
        }

        public bool Existe(Marca marca)
        {
            return marca.MarcaId == 0 ?
                _dbContext.Marcas.Any(m => m.Descripcion == marca.Descripcion)
                : _dbContext.Marcas.Any(m => m.Descripcion == marca.Descripcion
                && m.MarcaId == marca.MarcaId);
        }

        public int GetCantidad()
        {
            return _dbContext.Marcas.Count();
        }

        public List<Marca> GetPais(string? textoParaFiltrar = null)
        {
            return textoParaFiltrar is null ?
                _dbContext.Marcas.AsNoTracking().ToList()
                : _dbContext.Marcas.Where(m => m.Descripcion
                .StartsWith(textoParaFiltrar)).AsNoTracking().ToList();
        }

        public Marca? GetPorId(int marcaId)
        {
            return _dbContext.Marcas.AsNoTracking()
                .FirstOrDefault(m => m.MarcaId == marcaId);
        }
    }
}
