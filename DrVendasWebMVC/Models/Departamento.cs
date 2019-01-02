using System;
using System.Collections.Generic;
using System.Linq;

namespace DrVendasWebMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        //Um departamento tem varios vendedores 
        //Dessa forma estalecemos um relacionamento um para varios 
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        { }


        //Nao entra a coleção de vendedor
        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarVendedor(Vendedor objVendedor)
        {
            Vendedores.Add(objVendedor);
        }

        //Total de vendas por departamento
        public double TotalVendas(DateTime dtInicial, DateTime dtFinal)
        {
            //Soma o total de cada total de cada vendedor
            return Vendedores.Sum(vendedor => vendedor.TotalVendasPorPeriodo(dtInicial, dtFinal));
        }



    }


}
