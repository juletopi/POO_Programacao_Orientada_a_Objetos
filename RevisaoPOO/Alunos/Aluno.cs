using System;

namespace RevisaoPOO.Alunos
{
    public class Aluno // <-- Classe "Aluno"
    {
        // Atributos da classe "Aluno"
        public string nome; // <-- Nome do aluno
        public DateTime dataNasc; // <-- Data de nascimento do aluno
        public int idade; // <-- Idade do aluno

        // Método construtor da classe "Aluno"
        public Aluno(string nome, DateTime dataNasc) 
        {
            this.nome = nome; // <-- Parâmetro do atributo "nome"
            this.dataNasc = dataNasc; // <-- Parâmetro do atributo "dataNasc"

            // Calcula a idade do aluno com base no ano atual e no ano de nascimento do aluno
            idade = DateTime.Now.Year - dataNasc.Year;

            // Ajusta a idade caso a data de aniversário do aluno ainda não chegou no ano corrente
            if (DateTime.Now.DayOfYear < dataNasc.DayOfYear)
            {
                idade--; // <-- Reduz 1 ano se o aluno ainda não fez aniversário este ano
            }
        }

        // Método para exibir informações do aluno
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}"); // <-- Exibe o nome do aluno
            Console.WriteLine($"Data de Nascimento: {dataNasc.ToShortDateString()}"); // <-- Exibe a data de nascimento do aluno formatada como string
            Console.WriteLine($"Idade: {idade}"); // <-- Exibe a idade do aluno
        }
    }
}