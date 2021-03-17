using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Treinamento.Models
{
    public class Venda
    {
        public Guid Codigo { get; private set; }
        public DateTime Data { get; private set; }
        public Cliente Cliente { get; private set; }
        public List<Item>  Itens { get; private set; }
        public Venda(Cliente cliente)
        {
            Codigo = Guid.NewGuid();
            Data = DateTime.Now;
            Cliente = cliente;
            Itens = new List<Item>();

        }
        public void AddItem(Produto produto,int quantidade)
        {

        }
    }
}
