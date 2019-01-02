using DrVendasWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DrVendasWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }
        public Double SalarioBase { get; set; }

        //Um vendedor pertence a um departamento 
        //Dessa forma estalecemos um relacionamento um para um
        public Departamento Departamento { get; set; }

        //Um vendedor pode ter varias vendas 
        //Dessa forma estalecemos um relacionamento um para varios e já instancimaos
        public ICollection<Venda> Vendas { get; set; } = new List<Venda>();

        public Vendedor()
        { }

        //Nao entra a collection de vendas 
        public Vendedor(int id, string nome, string email, DateTime dataAniversario, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarVendas(Venda ve)
        {
            Vendas.Add(ve);
        }

        public void RemoveVendas(Venda ve)
        {
            Vendas.Remove(ve);
        }

        public double TotalVendasPorPeriodo(DateTime dtInicial, DateTime dtFinal)
        {
            //Vamos usar a nossa colecao de vendas do vendedor e usar o Linq
            //filtrando pelo paramentro dtinicial e dtFinal e em seguin somarmos usando a 
            //funcao sum do Linq
            return Vendas.Where(ve => ve.DataVenda >= dtInicial && 
                                                         ve.DataVenda <=  dtFinal).Sum(ve => ve.ValorTotal);
        }
    }

}
