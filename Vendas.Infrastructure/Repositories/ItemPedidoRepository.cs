using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces;
using Vendas.Infrastructure.Context;

namespace Vendas.Infrastructure.Repositories;

public class ItemPedidoRepository : GenericRepository<ItemPedido>, IItemPedidoRepository
{
    public ItemPedidoRepository(AppDbContext context) : base(context) { }
}
