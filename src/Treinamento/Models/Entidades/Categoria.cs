using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Treinamento.Models
{
    public class Categoria
    {     

        public Guid Codigo { get; set; }
        public string Nome { get; set; }

        public Categoria(string nome)
        {
            Nome = nome;
        }

        public Categoria(Guid codigo)
        {
            Codigo = codigo;
        }
    }
}
