using PrjVendas.Domain.Entities;
using PrjVendas.Domain.Interfaces;
using PrjVendas.Infrastructure.Context;

namespace PrjVendas.Infrastructure.Repositories;

public class ItemPedidoRepository : GenericRepository<ItemPedido>, IItemPedidoRepository
{
    public ItemPedidoRepository(AppDbContext context) : base(context) { }
}
