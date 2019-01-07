using DrVendasWebMVC.Models;
using DrVendasWebMVC.Models.ViewModels;
using DrVendasWebMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DrVendasWebMVC.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;
        private readonly DepartamentoService _departamentoService;

        public VendedoresController(VendedorService vendedorService, DepartamentoService departamentoService)
        {
            _vendedorService = vendedorService;
            _departamentoService = departamentoService;
        }

        public IActionResult Index()
        {
            var list = _vendedorService.BuscaTodosVendedores();
             return View(list);
        }

        public IActionResult Create() {
            //Carregar os departamento
            var departamentos = _departamentoService.BuscaTodosDepartamentos();
            var  viewModel = new VendedorFormViewModels { Departamento = departamentos};
            return View(viewModel);
          }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedorService.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }

    }
}