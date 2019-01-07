using System.Collections.Generic;

namespace DrVendasWebMVC.Models.ViewModels
{
    public class VendedorFormViewModels
    {
        public Vendedor Vendedor { get; set; }
        public List<Departamento> Departamento { get; internal set; }
        private ICollection<Departamento>Departamentos { get; set; }
      
    
    }
}
