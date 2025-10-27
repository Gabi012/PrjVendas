using Microsoft.AspNetCore.Mvc;
using Vendas.Application.Services;
using Vendas.Domain.Entities;

namespace Vendas.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PedidoController : ControllerBase
{
    private readonly PedidoService _service;
    public PedidoController(PedidoService service) { _service = service; }

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _service.ListarAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id) { var p = await _service.ObterPorIdComItensAsync(id); if (p==null) return NotFound(); return Ok(p); }

    [HttpPost]
    public async Task<IActionResult> Post(Pedido p) { var id = await _service.CriarAsync(p); return CreatedAtAction(nameof(Get), new { id }, p); }
}
