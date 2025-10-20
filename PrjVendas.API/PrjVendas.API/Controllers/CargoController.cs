using Microsoft.AspNetCore.Mvc;
using PrjVendas.Application.Services;
using PrjVendas.Domain.Entities;

namespace PrjVendas.API.Controllers;

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
