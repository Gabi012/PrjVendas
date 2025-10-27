using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vendas.Application.Dto;
using Vendas.Application.Services;
using Vendas.Domain.Entities;

namespace Vendas.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FuncionarioController : ControllerBase
{
    private readonly FuncionarioService _service;
    private readonly IMapper _mapper;
    public FuncionarioController(FuncionarioService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _service.ListarAsync());

    [HttpGet("{id}", Name = "GetById")]
    public async Task<IActionResult>  ObterPorIdAsync(int id) 
    {
        var func = await _service.ObterPorIdAsync(id);
        return Ok(func);
    } 

    [HttpPost]
    public async Task<IActionResult> Post(FuncionarioCreateDto f)
    {
        try
        {
            await _service.AdicionarAsync(f);
            var readDto = _mapper.Map<FuncionarioReadDto>(f);
            return new CreatedAtRouteResult("GetById", new { id = readDto.Id }, readDto);
            
        }
        catch (Exception ex) 
        { 
            return BadRequest(ex.Message);
        }
        
    }
}
