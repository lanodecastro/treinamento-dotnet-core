using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Treinamento.Models
{
    public class Item
    {

        public Venda Venda { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }

        public Item(Venda venda, Produto produto, int quantidade)
        {
            Venda = venda;
            Produto = produto;
            Quantidade = quantidade;
        }

    }
}
