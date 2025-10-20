using Microsoft.EntityFrameworkCore;
using PrjVendas.Application.Services;
using PrjVendas.Infrastructure.Context;
using PrjVendas.Infrastructure.Repositories;
using PrjVendas.Application.Profiles; 
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddAutoMapper(typeof(DomainToDTOProfile).Assembly);

// DI - repositórios e serviços
builder.Services.AddScoped(typeof(PrjVendas.Domain.Interfaces.IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<PrjVendas.Domain.Interfaces.IFuncionarioRepository, FuncionarioRepository>();
builder.Services.AddScoped<PrjVendas.Domain.Interfaces.ICargoRepository, CargoRepository>();
builder.Services.AddScoped<PrjVendas.Domain.Interfaces.ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<PrjVendas.Domain.Interfaces.IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<PrjVendas.Domain.Interfaces.IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<PrjVendas.Domain.Interfaces.IItemPedidoRepository, ItemPedidoRepository>();

builder.Services.AddScoped<FuncionarioService>();
builder.Services.AddScoped<ProdutoService>();
builder.Services.AddScoped<CategoriaService>();
builder.Services.AddScoped<CargoService>();
builder.Services.AddScoped<PedidoService>();
builder.Services.AddScoped<ItemPedidoService>();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Aplica migrações automaticamente ao iniciar (cria DB e aplica migrações pendentes)
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate(); // <-- importante: cria/aplica migrações
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
