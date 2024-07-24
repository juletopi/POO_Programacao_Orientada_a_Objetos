using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using RevisaoPOO.Alunos;

namespace RevisaoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário o nome do aluno
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            // Solicita ao usuário a data de nascimento do aluno
            Console.Write("Digite a data de nascimento do aluno (dd/MM/yyyy): ");
            DateTime dataNasc;

            // Tenta converter a entrada do usuário para DateTime até que uma data válida seja fornecida
            while (!DateTime.TryParse(Console.ReadLine(), out dataNasc))
            {
                Console.Write("Data inválida. Digite a data de nascimento do aluno (dd/MM/yyyy): ");
            }

            // Criação de um objeto da classe "Aluno"
            Aluno a1 = new Aluno(nome, dataNasc);

            // Chama o método para exibir as informações do aluno
            a1.ExibirInformacoes();

            Console.ReadKey();
        }
    }
}