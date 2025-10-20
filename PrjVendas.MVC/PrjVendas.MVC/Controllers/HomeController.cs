using Microsoft.AspNetCore.Mvc;

namespace PrjVendas.MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => RedirectToAction("Index", "Produto");
}
