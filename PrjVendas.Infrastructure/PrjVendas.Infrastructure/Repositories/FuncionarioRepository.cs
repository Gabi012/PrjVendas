using Microsoft.EntityFrameworkCore;
using PrjVendas.Domain.Entities;
using PrjVendas.Domain.Interfaces;
using PrjVendas.Infrastructure.Context;

namespace PrjVendas.Infrastructure.Repositories;

public class FuncionarioRepository : GenericRepository<Funcionario>, IFuncionarioRepository
{
    public FuncionarioRepository(AppDbContext context) : base(context) { }

    public async Task<Funcionario?> GetByCpfAsync(string cpf)
    {
        return await _dbSet.FirstOrDefaultAsync(f => f.Cpf == cpf);
    }
}
