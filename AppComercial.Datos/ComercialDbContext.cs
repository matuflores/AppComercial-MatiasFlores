using AppComercial.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AppComercial.Datos
{
    public class ComercialDbContext : DbContext
    {
        public ComercialDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ComercialDbContext()
        {
        }

        public DbSet<Marca> Marcas { get; set; }
    }
}
