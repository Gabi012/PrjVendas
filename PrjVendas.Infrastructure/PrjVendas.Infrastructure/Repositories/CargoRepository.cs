using PrjVendas.Domain.Entities;
using PrjVendas.Domain.Interfaces;
using PrjVendas.Infrastructure.Context;

namespace PrjVendas.Infrastructure.Repositories;

public class CargoRepository : GenericRepository<Cargo>, ICargoRepository
{
    public CargoRepository(AppDbContext context) : base(context) { }
}
