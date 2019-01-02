using DrVendasWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DrVendasWebMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento>  list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Eletrônicos" });
            list.Add(new Departamento { Id = 2, Nome = "Festas" });
            list.Add(new Departamento { Id = 3, Nome = "Alimentos" });
            list.Add(new Departamento { Id = 4, Nome = "Esportea" });
            return View(list);
        }
    }
}