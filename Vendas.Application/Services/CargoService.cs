using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces;

namespace Vendas.Application.Services;

public class CargoService
{
    private readonly ICargoRepository _repo;
    public CargoService(ICargoRepository repo) { _repo = repo; }
    public async Task<IEnumerable<Cargo>> ListarAsync() => await _repo.GetAllAsync();
    public async Task AdicionarAsync(Cargo c) { await _repo.AddAsync(c); await _repo.SaveChangesAsync(); }
}
