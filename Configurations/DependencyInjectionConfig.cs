using Microsoft.Extensions.DependencyInjection;
using Graos_API.Data.Context;
using Graos_API.Data.Repositories;
using Graos_API.Domain.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Graos_API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IAvulsaRepository, AvulsaRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<ILogRequisicoesRepository, LogRequisicoesRepository>();
            services.AddScoped<IMotoristaRepository, MotoristaRepository>();
            services.AddScoped<IPesagemRepository, PesagemRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IPropriedadeRepository, PropriedadeRepository>();
            services.AddScoped<ISaldoRepository, SaldoRepository>();

            services.AddScoped<AppDbContext>();
        }
    }
}
