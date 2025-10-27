using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Vendas.Application.Profiles;
using Vendas.Application.Services;
using Vendas.Domain.Interfaces;
using Vendas.Infrastructure.Context;
using Vendas.Infrastructure.Repositories;

namespace Vendas.CrossCutting.Ioc
{
    public static class DependencyInjectionAPI
    {
        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services,
       IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddAutoMapper(typeof(DomainToDTOProfile).Assembly);
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            services.AddScoped<ICargoRepository, CargoRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IItemPedidoRepository, ItemPedidoRepository>();

            services.AddScoped<FuncionarioService>();
            services.AddScoped<ProdutoService>();
            services.AddScoped<CategoriaService>();
            services.AddScoped<CargoService>();
            services.AddScoped<PedidoService>();
            services.AddScoped<ItemPedidoService>();
            services.AddAutoMapper(typeof(DomainToDTOProfile));

            return services;
        }
    }
}
