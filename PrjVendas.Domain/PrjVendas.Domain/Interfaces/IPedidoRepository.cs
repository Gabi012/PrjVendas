using PrjVendas.Domain.Entities;

namespace PrjVendas.Domain.Interfaces;

public interface IPedidoRepository : IGenericRepository<Pedido>
{
    Task<Pedido?> GetWithItemsAsync(int id);
}
