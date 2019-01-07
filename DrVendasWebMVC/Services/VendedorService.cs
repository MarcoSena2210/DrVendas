using DrVendasWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace DrVendasWebMVC.Services
{
    public class VendedorService
    {
        private readonly DrVendasWebMVCContext _context;

        public VendedorService(DrVendasWebMVCContext context)
        {
            _context = context;
        }

        public  List<Vendedor> BuscaTodosVendedores()
        {
            return _context.Vendedor.ToList();
        }
        public void Insert(Vendedor obj) {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
