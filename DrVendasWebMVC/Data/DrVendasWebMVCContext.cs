using Microsoft.EntityFrameworkCore;

namespace DrVendasWebMVC.Models
{
    public class DrVendasWebMVCContext : DbContext
    {
        public DrVendasWebMVCContext (DbContextOptions<DrVendasWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
   
    }
}
