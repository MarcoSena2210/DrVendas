using DrVendasWebMVC.Models;
using DrVendasWebMVC.Models.Enums;
using System;

namespace DrVendasWebMVC.Models
{ 
    public class Venda
    {
            public int Id { get; set; }
            public DateTime DataVenda{ get; set; }
            public Double ValorTotal { get; set; }
            public StatusVenda Status { get; set; }

        //Cada venda possui um vendedor 
        //Dessa forma estalecemos um relacionamento um para um
        public Vendedor Vendedor { get; set; }
   
        //Vamos crias os construtores 
        public Venda()
        {        }

        public Venda(int id, DateTime dataVenda, double valorTotal, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            DataVenda = dataVenda;
            ValorTotal = valorTotal;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
