using PrjVendas.Domain.Entities;
using PrjVendas.Domain.Interfaces;
using PrjVendas.Infrastructure.Context;

namespace PrjVendas.Infrastructure.Repositories;

public class ProdutoRepository : GenericRepository<Produto>, IProdutoRepository
{
    public ProdutoRepository(AppDbContext context) : base(context) { }
}
