using PrjVendas.Domain.Entities;

namespace PrjVendas.Domain.Interfaces;

public interface IFuncionarioRepository : IGenericRepository<Funcionario>
{
    Task<Funcionario?> GetByCpfAsync(string cpf);
}
