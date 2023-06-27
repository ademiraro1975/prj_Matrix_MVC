using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using matriz.Core.Application.Interfaces;
using matriz.Core.Application.Mappings;
using matriz.Core.Application.Services;
using matriz.Core.Domain.Interfaces;
using matriz.Infra.Data.Context;
using matriz.Infra.Data.Repositories;

namespace matriz.Infra.IoC
{
    public static class DependencyInjection
    {
        private static readonly string _conectionString = "Server=172.16.4.122;Database=DadosSAADB;Trusted_Connection=True;TrustServerCertificate=True;";
        private static readonly string _conectionStringMatrizDB = "Server=172.16.4.122;Database=MATRIZDB;Trusted_Connection=True;TrustServerCertificate=True;";

        //private static readonly string _conectionString = "Server=10.102.1.4;Database=DadosSAADB;User ID=fieb;Password=hb@C1#qB3;";

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //var configuration = DatabaseConfiguration.Configuration;

            services.AddDbContext<AppDbContext>(
                    options => options.UseSqlServer(_conectionString,
                            //configuration.GetConnectionString("DefaultConnection"),
                            b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)
                        )
                    );

            services.AddDbContext<PizzariaContext>(
                    options => options.UseSqlServer(_conectionStringMatrizDB,
                            //configuration.GetConnectionString("DefaultConnection"),
                            b => b.MigrationsAssembly(typeof(PizzariaContext).Assembly.FullName)
                        )
                    );

            //Repositories
            services.AddScoped<IEstadoRepository, EstadoRepository>();
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            services.AddScoped<IFuncionarioPermissaoRepository, FuncionarioPermissaoRepository>();
            services.AddScoped<IPizzaRepository, PizzaRepository>();
            services.AddScoped<IRefrigeranteRepository, RefrigeranteRepository>();
            services.AddScoped<IIngredienteRepository, IngredienteRepository>();
            services.AddScoped<ITipoRepository, TipoRepository>();
            services.AddScoped<ITabelaPrecoRepository, TabelaPrecoRepository>();
            services.AddScoped<ITamanhoRepository, TamanhoRepository>();
            //Services
            services.AddScoped<IEstadoService, EstadoService>();
            services.AddScoped<IFuncionarioPermissaoService, FuncionarioPermissaoService>();
            services.AddScoped<IHashService, HashSevice>();
            services.AddScoped<IPizzaService, PizzaService>();
            services.AddScoped<IRefrigeranteService, RefrigeranteService>();
            services.AddScoped<IFuncionarioService, FuncionarioService>();
            services.AddScoped<IIngredienteService, IngredienteService>();
            services.AddScoped<ITamanhoService, TamanhoService>();
            services.AddScoped<ITipoService, TipoService>();
            services.AddScoped<ITabelaPrecoService, TabelaPrecoService>();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}