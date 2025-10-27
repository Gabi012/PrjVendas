using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces;
using Vendas.Infrastructure.Context;

namespace Vendas.Infrastructure.Repositories;

public class CargoRepository : GenericRepository<Cargo>, ICargoRepository
{
    public CargoRepository(AppDbContext context) : base(context) { }
}
