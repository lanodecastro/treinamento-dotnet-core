using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Treinamento.Models
{
    public class Produto
    {      
        public int Codigo { get; private set; }
        public string Nome { get;private set; }
        public int QuantidadeEstoque { get; private set; }
        public Categoria Categoria { get; private set; }
        public decimal Preco { get; private set; }

        public Produto(string nome, int quantidadeEstoque, Categoria categoria, decimal preco)
        {
            Nome = nome;
            QuantidadeEstoque = quantidadeEstoque;
            Categoria = categoria;
            Preco = preco;
        }


    }
}
