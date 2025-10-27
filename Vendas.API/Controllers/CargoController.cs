using Microsoft.AspNetCore.Mvc;
using Vendas.Application.Services;
using Vendas.Domain.Entities;

namespace Vendas.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CargoController : ControllerBase
{
    private readonly CargoService _service;
    public CargoController(CargoService service) { _service = service; }

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _service.ListarAsync());

    [HttpPost]
    public async Task<IActionResult> Post(Cargo c) { await _service.AdicionarAsync(c); return CreatedAtAction(nameof(Get), new { id = c.Id }, c); }
}
