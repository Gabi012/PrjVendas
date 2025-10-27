using Vendas.Domain.Entities;

namespace Vendas.Domain.Interfaces;

public interface IFuncionarioRepository : IGenericRepository<Funcionario>
{
    Task<Funcionario?> GetByCpfAsync(string cpf);
}
