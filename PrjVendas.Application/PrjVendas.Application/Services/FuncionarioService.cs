using PrjVendas.Domain.Entities;
using PrjVendas.Domain.Interfaces;

namespace PrjVendas.Application.Services;

public class FuncionarioService
{
    private readonly IFuncionarioRepository _funcRepo;

    public FuncionarioService(IFuncionarioRepository funcRepo)
    {
        _funcRepo = funcRepo;
    }

    public async Task<IEnumerable<Funcionario>> ListarAsync() => await _funcRepo.GetAllAsync();
    public async Task<Funcionario?> ObterPorIdAsync(int id) => await _funcRepo.GetByIdAsync(id);
    public async Task<Funcionario?> ObterPorCpfAsync(string cpf) => await _funcRepo.GetByCpfAsync(cpf);
    public async Task AdicionarAsync(Funcionario f) { await _funcRepo.AddAsync(f); await _funcRepo.SaveChangesAsync(); }
    public async Task AtualizarAsync(Funcionario f) { _funcRepo.Update(f); await _funcRepo.SaveChangesAsync(); }
    public async Task ExcluirAsync(int id) { var f = await _funcRepo.GetByIdAsync(id); if (f != null) { _funcRepo.Delete(f); await _funcRepo.SaveChangesAsync(); } }
}
