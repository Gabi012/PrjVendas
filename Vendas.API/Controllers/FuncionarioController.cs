using Microsoft.AspNetCore.Mvc;
using Vendas.Application.Services;
using Vendas.Domain.Entities;

namespace Vendas.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FuncionarioController : ControllerBase
{
    private readonly FuncionarioService _service;
    public FuncionarioController(FuncionarioService service) 
    { _service = service; }

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _service.ListarAsync());

    //[HttpPost]
    //public async Task<IActionResult> Post(Funcionario f)
    //{ 
    //    await _service.AdicionarAsync(f); 
    //    return CreatedAtAction(nameof(Get), new { id = f.Id }, f); 
    //}
}
