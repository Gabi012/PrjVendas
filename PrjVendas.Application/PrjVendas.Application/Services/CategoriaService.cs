using PrjVendas.Domain.Entities;
using PrjVendas.Domain.Interfaces;

namespace PrjVendas.Application.Services;

public class CategoriaService
{
    private readonly ICategoriaRepository _repo;
    public CategoriaService(ICategoriaRepository repo) { _repo = repo; }
    public async Task<IEnumerable<Categoria>> ListarAsync() => await _repo.GetAllAsync();
    public async Task AdicionarAsync(Categoria c) { await _repo.AddAsync(c); await _repo.SaveChangesAsync(); }
}
