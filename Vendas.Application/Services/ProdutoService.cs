using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces;

namespace Vendas.Application.Services;

public class ProdutoService
{
    private readonly IProdutoRepository _repo;
    public ProdutoService(IProdutoRepository repo) { _repo = repo; }
    public async Task<IEnumerable<Produto>> ListarAsync() => await _repo.GetAllAsync();
    public async Task<Produto?> ObterPorIdAsync(int id) => await _repo.GetByIdAsync(id);
    public async Task AdicionarAsync(Produto p) { await _repo.AddAsync(p); await _repo.SaveChangesAsync(); }
}
