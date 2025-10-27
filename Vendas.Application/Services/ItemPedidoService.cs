using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces;

namespace Vendas.Application.Services;

public class ItemPedidoService
{
    private readonly IItemPedidoRepository _repo;
    public ItemPedidoService(IItemPedidoRepository repo) { _repo = repo; }
    public async Task<IEnumerable<ItemPedido>> ListarAsync() => await _repo.GetAllAsync();
    public async Task AdicionarAsync(ItemPedido i) { await _repo.AddAsync(i); await _repo.SaveChangesAsync(); }
}
