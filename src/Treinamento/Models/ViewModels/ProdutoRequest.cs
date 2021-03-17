using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Treinamento.Models.ViewModels
{
    public class ProdutoRequest
    {
        public string Nome { get; set; }
        public int QuantidadeEstoque { get; set; }
        public decimal Preco { get; set; }
        public CategoriaRequest Categoria { get; set; }
        public List<CategoriaRequest> Categorias { get; set; }

        public ProdutoRequest()
        {
            Categorias = new List<CategoriaRequest>();
            Categorias.Add(new CategoriaRequest("Games"));
            Categorias.Add(new CategoriaRequest("Instrumentos Musicais"));
            Categorias.Add(new CategoriaRequest("Eletrônicos"));
            Categorias.Add(new CategoriaRequest("Comida"));
        }


    }
}
