using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EmbarqueVoos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // QUESTÃO 01:

            // Escreva uma classe em que cada objeto representa um voo que acontece em determinada data e em determinado horário.
            // Cada voo possui um número máximo de passageiros, e a classe permite controlar a ocupação das vagas.
            // Cada voo possui um número do voo. A classe deve ter os seguintes métodos:

            // • 1. Construtor: configura os dados do voo (recebidos como parâmetro): número do voo, data;
            // • 2. ProximoLivre: retorna o número da próxima cadeira livre;
            // • 3. Verifica: verifica se o número da cadeira recebido como parâmetro está ocupada;
            // • 4. Ocupa: ocupa determinada cadeira do voo, cujo número é recebido como parâmetro, e retorna
            // verdadeiro se a cadeira ainda não estiver ocupada (operação foi bem sucedida) e falso caso contrário;
            // • 5. Vagas: retorna o número de cadeiras vagas disponíveis (não ocupadas) no voo;
            // • 6. GetVoo: retorna o número do voo;
            // • 7. GetData: retorna a data do voo.

            // -------------------------------------------------------------------------------

            Voo voo = new Voo(1, new DateTime(2024, 3, 13), 100); // <-- Criando um voo

            // Exemplo de uso dos 6 métodos
            Console.Write("\r\n ┌──────────────────────────────────────┐");
            Console.Write("\r\n │ Embarque de Voos - Uso dos 6 métodos │");
            Console.Write("\r\n └──────────────────────────────────────┘\r\n");

            Console.WriteLine("\n 1. Próxima cadeira livre: " + voo.ProximoLivre());
            Console.WriteLine(" 2. Verificando cadeira 5: " + voo.Verifica(5));
            Console.WriteLine(" 3. Ocupando cadeira 5: " + voo.Ocupa(5));
            Console.WriteLine(" 4. Número de cadeiras vagas: " + voo.Vagas());
            Console.WriteLine(" 5. Número do voo: " + voo.GetVoo());
            Console.WriteLine(" 6. Data do voo: " + voo.GetData());

            // Exemplo de interação com o usuário
            Console.Write("\r\n ┌────────────────────────────────────────────┐");
            Console.Write("\r\n │ Embarque de Voos - Interação com o usuário │");
            Console.Write("\r\n └────────────────────────────────────────────┘\r\n");

            while (true)
            {
                Console.WriteLine("\r\n -----------------------------------------");
                Console.WriteLine("\n Escolha uma opção:");
                Console.WriteLine(" 1 - Verificar disponibilidade de assento");
                Console.WriteLine(" 2 - Ocupar um assento");
                Console.WriteLine(" 3 - Próxima cadeira livre");
                Console.WriteLine(" 4 - Sair");

                Console.Write("\n Opção escolhida: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("\n Digite o número do assento: ");
                        int numAssento = int.Parse(Console.ReadLine());
                        if (voo.Verifica(numAssento))
                        {
                            Console.WriteLine("\n O assento " + numAssento + " está ocupado!");
                            Console.WriteLine(" Aperte ENTER para continuar...");
                        }
                        else
                        {
                            Console.WriteLine("\n O assento " + numAssento + " está livre.");
                            Console.WriteLine(" Aperte ENTER para continuar...");
                        }
                    break;
                    case "2":
                        Console.Write("\n Digite o número do assento que deseja ocupar: ");
                        int assento = int.Parse(Console.ReadLine());
                        if (voo.Ocupa(assento))
                        {
                            Console.WriteLine("\n Assento " + assento + " ocupado com sucesso!");
                            Console.WriteLine(" Aperte ENTER para continuar...");
                        }
                        else
                        {
                            Console.WriteLine("\n Assento " + assento + " já está ocupado!");
                            Console.WriteLine(" Aperte ENTER para continuar...");
                        }
                    break;
                    case "3":
                        int proxAssento = voo.ProximoLivre();
                        if (proxAssento != -1)
                        {
                            Console.WriteLine("\n A próxima cadeira livre é: " + proxAssento);
                            Console.WriteLine(" Aperte ENTER para continuar...");
                        }
                        else
                        {
                            Console.WriteLine("\n Não há cadeiras livres disponíveis.");
                            Console.WriteLine(" Aperte ENTER para continuar...");
                        }
                    break;
                    case "4":
                        Console.WriteLine("\n Fechando o sistema. Até logo!");
                        return;
                    default:
                        Console.WriteLine("\n Opção inválida. Por favor, escolha uma opção válida!");
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}