using Microsoft.AspNetCore.Mvc;
using PrjVendas.Application.Services;

namespace PrjVendas.MVC.Controllers;

public class ProdutoController : Controller
{
    private readonly ProdutoService _service;
    public ProdutoController(ProdutoService service) { _service = service; }
    public async Task<IActionResult> Index() => View(await _service.ListarAsync());
}
