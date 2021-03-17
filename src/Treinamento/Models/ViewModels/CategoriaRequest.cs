using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Treinamento.Models.ViewModels
{
    public class CategoriaRequest
    {
        public Guid Codigo { get; set; }
        public string Nome { get; set; }

        public CategoriaRequest()
        {
            Codigo = Guid.NewGuid();
        }

        public CategoriaRequest(string nome)
        {
            Codigo = Guid.NewGuid();
            Nome = nome;
        }
    }
}
