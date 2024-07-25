using System;

namespace RevisaoPOO2.Classes
{
    public class Alunos // <-- Classe Alunos
    {
        // Atributos da classe Alunos
        public string nome;
        public int matricula;
        public string cpf;
        public string email;
        public DateTime dataNasc;

        // Método construtor da classe Alunos
        public Alunos (string alunoNome, int alunoMatricula, string alunoCPF, string alunoEmail, DateTime alunoDataNasc)
        {
            nome = alunoNome;
            matricula = alunoMatricula;
            cpf = alunoCPF;
            email = alunoEmail;
            dataNasc = alunoDataNasc;
        }

        // Sobrescrevendo o método ToString para fornecer uma representação em string dos dados do aluno
        public override string ToString()
        {
            return "Nome: " + nome + " - " + "Matrícula: " + matricula + " - " + "CPF: " + cpf + " - " + "E-mail: " + email + " - " + "Data de Nascimento: " + dataNasc.ToString();
        }
    }
}