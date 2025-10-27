using Microsoft.AspNetCore.Mvc;
using Vendas.Application.Services;
using Vendas.Domain.Entities;

namespace Vendas.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly ProdutoService _service;
    public ProdutoController(ProdutoService service) { _service = service; }

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _service.ListarAsync());

    [HttpPost]
    public async Task<IActionResult> Post(Produto p) { await _service.AdicionarAsync(p); return CreatedAtAction(nameof(Get), new { id = p.Id }, p); }
}
