using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_de_Nivelamento__POO_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AVALIAÇÃO DE NIVELAMENTO DE PROGRAMAÇÃO ORIENTADA A OBJETOS

            // 1. A média final de um aluno em uma determinada disciplina é calculada com base no número de atividades avaliativas aplicadas pelo professor. 
            // Você foi escolhido para construir um programa que realize o cálculo de média de cada aluno. 
            // Faça um programa que receba o nome e duas notas de um aluno, o programa deve calcular a média e informar a média do aluno e se ele foi aprovado ou não. 
            // Para ser aprovado a média deve ser igual ou superior a 60 pontos.

            // 2. O programa desenvolvido na atividade anterior só funciona para duas notas, 
            // faça um programa que receba o nome do aluno, a quantidade de atividades avaliativas, as notas das referidas atividades. 
            // Ao fim, calcule a média e apresente se o aluno foi aprovado ou não.

            // 3. O programa da questão 2 funciona apenas para cálculo de média, 
            // no entanto, caso o professor faça a opção de média ponderada, o mesmo não irá atender à situação. 
            // Pensando nisso, faça uma opção (pode usar um menu ou outro programa) que receba a quantidade de atividades avaliativas, o peso de cada atividade. 
            // Posteriormente, leia o nome de um aluno, as notas obtidas em cada atividade, calcule e apresente a média e se o aluno foi ou não aprovado. 

            // 4. O fatorial de um número é a multiplicação desse número por todos os seus antecessores maiores que zero. 
            // Para representar o fatorial de um número, escrevemos o número seguido de um ponto de exclamação, ou seja, n! (lê-se “n fatorial”). 
            // Por exemplo, o fatorial do número 5 é 5!, que é a multiplicação de 5 pelos seus antecessores, ou seja, 5⋅4⋅3⋅2⋅1. 
            // Faça um programa que receba um número e calcule o seu fatorial.

            // -------------------------------------------------------------------------------

            Console.Write("\r\n ┌───────────────────────────────────────────────────────────────────┐");
            Console.Write("\r\n │ Este programa registra a média do aluno em diferentes avaliações. │");
            Console.Write("\r\n └───────────────────────────────────────────────────────────────────┘\r\n");

            while (true)
            {
                Console.WriteLine("\r\n -----------------------------------------");
                Console.WriteLine("\r\n 1. Calcular média com 2 notas");
                Console.WriteLine(" 2. Calcular média com várias notas");
                Console.WriteLine(" 3. Calcular média ponderada");
                Console.WriteLine(" 4. Calcular fatorial");
                Console.WriteLine(" 5. Sair");
                Console.WriteLine("\r\n -----------------------------------------");
                Console.Write("\r\n Digite o número da opção desejada: ");

                int opcEscolha = Convert.ToInt32(Console.ReadLine());

                switch (opcEscolha)
                {
                    case 1:
                        CalcularMediaDuasNotas();
                        break;
                    case 2:
                        CalcularMediaVariasNotas();
                        break;
                    case 3:
                        CalcularMediaPonderada();
                        break;
                    case 4:
                        CalcularFatorial();
                        break;
                    case 5:
                        Console.WriteLine("Saindo do programa... Desligando agora, até mais!");
                        return;
                    default:
                        Console.WriteLine("\r\n Opção inválida! Por favor, selecione uma opção válida.");
                        break;
                }
            }
        }

        static void CalcularMediaDuasNotas()
        {
            Console.Write("\r\n Digite o nome do(a) aluno(a): ");
            string nome_aluno = Console.ReadLine();

            Console.Write(" Digite a primeira nota: ");
            double nota_1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Digite a segunda nota: ");
            double nota_2 = Convert.ToDouble(Console.ReadLine());

            double media = (nota_1 + nota_2) / 2;

            Console.WriteLine($"\r\n Média do aluno {nome_aluno}: {media}");

            if (media >= 60)
            {
                Console.WriteLine($"\r\n Média do(a) aluno(a) '{nome_aluno}' é igual a {media:F2}.");
                Console.WriteLine(" Requisito mínimo de média maior ou igual a 60pts atingido. Aluno(a) está APROVADO!");
            }
            else
            {
                Console.WriteLine($"\r\n Média do(a) aluno(a) '{nome_aluno}' é igual a {media:F2}.");
                Console.WriteLine(" Requisito mínimo de média maior ou igual a 60pts NÃO atingido. Aluno(a) está REPROVADO!");
            }
        }

        static void CalcularMediaVariasNotas()
        {
            Console.Write("\r\n Digite o nome do(a) aluno(a): ");
            string nome_aluno = Console.ReadLine();

            Console.Write(" Digite a quantidade de avaliações: ");
            int num_avaliacoes = Convert.ToInt32(Console.ReadLine());

            double soma_notas = 0;

            for (int i = 1; i <= num_avaliacoes; i++)
            {
                Console.Write($" Digite a nota da avaliação {i}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                soma_notas += nota;
            }

            double media = soma_notas / num_avaliacoes;

            Console.WriteLine($"\r\n Média do(a) aluno(a) {nome_aluno}: {media}");

            if (media >= 60)
            {
                Console.WriteLine($"\r\n Média do(a) aluno(a) '{nome_aluno}' é igual a {media:F2}.");
                Console.WriteLine(" Requisito mínimo de média maior ou igual a 60pts atingido. Aluno(a) está APROVADO!");
            }
            else
            {
                Console.WriteLine($"\r\n Média do(a) aluno(a) '{nome_aluno}' é igual a {media:F2}.");
                Console.WriteLine(" Requisito mínimo de média maior ou igual a 60pts NÃO atingido. Aluno(a) está REPROVADO!");
            }
        }

        static void CalcularMediaPonderada()
        {
            Console.Write("\r\n Digite o nome do(a) aluno(a): ");
            string nome_aluno = Console.ReadLine();

            Console.Write(" Digite a quantidade de avaliações: ");
            int num_avaliacoes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\r\n Digite o peso de cada avaliação:");
            List<double> pesos = new List<double>();

            for (int i = 1; i <= num_avaliacoes; i++)
            {
                Console.Write($" Peso da avaliação {i}: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                pesos.Add(peso);
            }

            double soma_notas = 0;
            double soma_pesos = 0;

            for (int i = 1; i <= num_avaliacoes; i++)
            {
                Console.Write($" Digite a nota da avaliação {i}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                soma_notas += nota * pesos[i - 1];
                soma_pesos += pesos[i - 1];
            }

            double media = soma_notas / soma_pesos;

            Console.WriteLine($"\r\n Média do aluno {nome_aluno}: {media}");

            if (media >= 60)
            {
                Console.WriteLine($"\r\n Média do(a) aluno(a) '{nome_aluno}' é igual a {media:F2}.");
                Console.WriteLine(" Requisito mínimo de média maior ou igual a 60pts atingido. Aluno(a) está APROVADO!");
            }
            else
            {
                Console.WriteLine($"\r\n Média do(a) aluno(a) '{nome_aluno}' é igual a {media:F2}.");
                Console.WriteLine(" Requisito mínimo de média maior ou igual a 60pts NÃO atingido. Aluno(a) está REPROVADO!");
            }
        }

        static void CalcularFatorial()
        {
            Console.Write("\r\n Digite um número para calcular o fatorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            long fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"\r\n O fatorial de {numero} é {fatorial}");

            Console.ReadKey();
        }
    }
}