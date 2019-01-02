using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DrVendasWebMVC.Models
{
    public class DrVendasWebMVCContext : DbContext
    {
        public DrVendasWebMVCContext (DbContextOptions<DrVendasWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<DrVendasWebMVC.Models.Departamento> Departamento { get; set; }
    }
}
