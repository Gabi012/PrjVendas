using Microsoft.EntityFrameworkCore;
using PrjVendas.Application.Services;
using PrjVendas.Infrastructure.Context;
using PrjVendas.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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


var app = builder.Build();


// Aplica migrações automaticamente ao iniciar
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate(); // cria/aplica migrações
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
