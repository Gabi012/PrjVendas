using Microsoft.AspNetCore.Mvc;
using PrjVendas.Application.Services;

namespace PrjVendas.MVC.Controllers;

public class PedidoController : Controller
{
    private readonly PedidoService _service;
    public PedidoController(PedidoService service) { _service = service; }
    public async Task<IActionResult> Index() => View(await _service.ListarAsync());
}
