using Microsoft.AspNetCore.Mvc;
using Vendas.Application.Services;
using Vendas.Domain.Entities;

namespace Vendas.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemPedidoController : ControllerBase
{
    private readonly ItemPedidoService _service;
    public ItemPedidoController(ItemPedidoService service) { _service = service; }

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _service.ListarAsync());

    [HttpPost]
    public async Task<IActionResult> Post(ItemPedido i) { await _service.AdicionarAsync(i); return CreatedAtAction(nameof(Get), new { id = i.Id }, i); }
}
