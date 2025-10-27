using Vendas.Domain.Entities;
namespace Vendas.Domain.Interfaces;

public interface IPedidoRepository : IGenericRepository<Pedido>
{
    Task<Pedido?> GetWithItemsAsync(int id);
}
