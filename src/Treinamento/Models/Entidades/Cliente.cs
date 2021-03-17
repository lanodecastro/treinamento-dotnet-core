using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Treinamento.Models
{
    public class Cliente
    {
        public string CPF { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }

        public Cliente(string cpf, string nome, string email, string telefone)
        {
            CPF = cpf;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }

    }
}
