using DrVendasWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrVendasWebMVC.Services
{
    public class DepartamentoService
    {
        private readonly DrVendasWebMVCContext _context;

        public DepartamentoService(DrVendasWebMVCContext context)
        {
            _context = context;
        }

        public List<Departamento> BuscaTodosDepartamentos()
        {
            return _context.Departamento.OrderBy(x =>x.Nome).ToList();
        }
    }
}
