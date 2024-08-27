using System;

namespace Conexao_com_SQL__POO_.Models
{
    internal class Aluno
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}