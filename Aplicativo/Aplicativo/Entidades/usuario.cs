
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicativo.Entidades
{
     public class Usuario
    {
        public int IdCadastro;
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string TipoUsuario { get; set; }
        public string Senha { get; set; }
        public string Login { get; set; }
        public int Nivel { get; set; }
        public int CodigoLogin { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<string> Qualificacao = new List<string>();
        public Endereco endereco { get; set; }

    }

}

