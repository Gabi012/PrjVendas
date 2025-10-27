using Microsoft.EntityFrameworkCore;
using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces;
using Vendas.Infrastructure.Context;

namespace Vendas.Infrastructure.Repositories;

public class FuncionarioRepository : GenericRepository<Funcionario>, IFuncionarioRepository
{
    public FuncionarioRepository(AppDbContext context) : base(context) { }

    public async Task<Funcionario?> GetByCpfAsync(string cpf)
    {
        return await _dbSet.FirstOrDefaultAsync(f => f.Cpf == cpf);
    }
}
