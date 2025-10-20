using Microsoft.EntityFrameworkCore;
using PrjVendas.Domain.Entities;
using PrjVendas.Domain.Interfaces;
using PrjVendas.Infrastructure.Context;

namespace PrjVendas.Infrastructure.Repositories;

public class PedidoRepository : GenericRepository<Pedido>, IPedidoRepository
{
    private readonly AppDbContext _context;
    public PedidoRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Pedido?> GetWithItemsAsync(int id)
    {
        return await _context.Pedidos
            .Include(p => p.Itens)
            .ThenInclude(i => i.Produto)
            .FirstOrDefaultAsync(p => p.Id == id);
    }
}
