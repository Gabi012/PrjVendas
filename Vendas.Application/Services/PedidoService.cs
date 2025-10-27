using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces;

namespace Vendas.Application.Services;

public class PedidoService
{
    private readonly IPedidoRepository _repo;
    public PedidoService(IPedidoRepository repo) { _repo = repo; }
    public async Task<IEnumerable<Pedido>> ListarAsync() => await _repo.GetAllAsync();
    public async Task<Pedido?> ObterPorIdComItensAsync(int id) => await _repo.GetWithItemsAsync(id);
    public async Task<int> CriarAsync(Pedido p) { await _repo.AddAsync(p); await _repo.SaveChangesAsync(); return p.Id; }
}
