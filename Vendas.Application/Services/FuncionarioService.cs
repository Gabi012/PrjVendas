using AutoMapper;
using Vendas.Application.Dto;
using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces;
using Vendas.Application.Profiles;

namespace Vendas.Application.Services;

public class FuncionarioService
{
    private readonly IFuncionarioRepository _funcRepo;
    private readonly IMapper _mapper;


    public FuncionarioService(IFuncionarioRepository funcRepo, IMapper mapper)
    {
        _funcRepo = funcRepo;
        _mapper = mapper;
    }

    public async Task<IEnumerable<Funcionario>> ListarAsync() => await _funcRepo.GetAllAsync();
    public async Task<FuncionarioReadDto?> ObterPorIdAsync(int id)
    {
        var funcionario = await _funcRepo.GetByIdAsync(id);
        var read = _mapper.Map<FuncionarioReadDto>(funcionario);
        return read;


    }
    public async Task<Funcionario?> ObterPorCpfAsync(string cpf) => await _funcRepo.GetByCpfAsync(cpf);
    public async Task AdicionarAsync(FuncionarioCreateDto f)
    {
        var funcionario = _mapper.Map<Funcionario>(f);
        await _funcRepo.AddAsync(funcionario);
        await _funcRepo.SaveChangesAsync();

    }

    public async Task AtualizarAsync(Funcionario f) { _funcRepo.Update(f); await _funcRepo.SaveChangesAsync(); }
    public async Task ExcluirAsync(int id) { var f = await _funcRepo.GetByIdAsync(id); if (f != null) { _funcRepo.Delete(f); await _funcRepo.SaveChangesAsync(); } }
}
