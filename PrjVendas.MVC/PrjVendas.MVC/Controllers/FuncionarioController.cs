using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrjVendas.Application.Services;
using PrjVendas.Domain.Entities;
using PrjVendas.MVC.Models;
using PrjVendas.Application.Dto;


namespace PrjVendas.MVC.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioService _funcionarioService;
        private readonly CargoService _cargoService;

        private readonly IMapper _mapper;

        public FuncionarioController(FuncionarioService funcionarioService, CargoService cargoService, IMapper mapper) 
        {
            _funcionarioService = funcionarioService;
            _cargoService = cargoService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var cargos = await _cargoService.ListarAsync(); // <- await aqui!

            var viewModel = new FuncionarioViewModel
            {
                ListaCargos = cargos.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Nome
                }).ToList()
            };

            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Create(FuncionarioViewModel f)
        {
            if (!ModelState.IsValid)
            {
                var cargos = await _cargoService.ListarAsync();
                f.ListaCargos = cargos.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Nome
                }).ToList();

                return View(f);
            }

            var dto = _mapper.Map<FuncionarioDTO>(f);
            await _funcionarioService.AdicionarAsync(dto);

            TempData["Mensagem"] = "Funcionário criado com sucesso!";
            return RedirectToAction("Create");
        }


    }
}
