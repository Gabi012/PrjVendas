using Microsoft.AspNetCore.Mvc;
using Vendas.Application.Services;
using Vendas.Domain.Entities;

namespace Vendas.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriaController : ControllerBase
{
    private readonly CategoriaService _service;
    public CategoriaController(CategoriaService service) { _service = service; }

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _service.ListarAsync());

    [HttpPost]
    public async Task<IActionResult> Post(Categoria c) { await _service.AdicionarAsync(c); return CreatedAtAction(nameof(Get), new { id = c.Id }, c); }
}
