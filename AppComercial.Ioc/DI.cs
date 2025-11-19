
using AppComercial.Datos;
using AppComercial.Datos.Interfaces;
using AppComercial.Datos.Repositorios;
using AppComercial.Servicios.Interfaces;
using AppComercial.Servicios.Mapping;
using AppComercial.Servicios.Servicios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace AppComercial.Ioc
{
    public static class DI
    {
        private static IServiceProvider? _serviceProvider;
        public static IServiceProvider ConfigurarDI()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ComercialDbContext>(options =>
            {
                options.UseSqlServer(ConfigurationManager
                    .ConnectionStrings["MiConexion"]
                    .ConnectionString);
            });

            services.AddScoped<IMarcaRepositorio, MarcaRepositorio>();//

            services.AddScoped<IMarcaServicio, MarcaServicio>();

            services.AddAutoMapper(typeof(MappingProfile).Assembly);
            _serviceProvider = services.BuildServiceProvider();

            return services.BuildServiceProvider();
        }
        public static IServiceProvider? ServiceProvider => _serviceProvider ?? throw new NotImplementedException("DEPENDENCIAS NO ESTABLECIDAS");

    }
}
