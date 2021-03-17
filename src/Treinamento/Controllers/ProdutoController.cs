using Microsoft.AspNetCore.Mvc;
using Treinamento.Models;
using Treinamento.Models.ViewModels;

namespace Treinamento.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NovoProduto()
        {
            return View(new ProdutoRequest());
        }
        public IActionResult GravarProduto(ProdutoRequest produtoRequest)
        {
            if (produtoRequest.Categoria == null)
                return View();

            var categoria = new Categoria(produtoRequest.Categoria.Codigo);

            var produto = new Produto(produtoRequest.Nome, produtoRequest.QuantidadeEstoque, categoria, produtoRequest.Preco);

            return View(produtoRequest);
        }
    }
}
