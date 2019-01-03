using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrVendasWebMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DrVendasWebMVC.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;

        public VendedoresController(VendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        public IActionResult Index()
        {
            var list = _vendedorService.BuscaTodosVendedores();
             return View(list);
        }
    }
}