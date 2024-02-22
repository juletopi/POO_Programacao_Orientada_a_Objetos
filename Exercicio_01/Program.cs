using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie uma classe "ContaBancaria" que possui os seguintes atributos: ID, Agência, Nº da Conta, Nome do Proprietário e Saldo.

            // • Crie uma instância da conta, pedindo ao usuário do sistema que informe os dados dos atributos;

            // • Crie um método chamado "Depósito", esse método deve receber um parâmetro com o valor
            // (valor acrescido no saldo). No entanto, não pode acrescentar no saldo valores negativos.

            // • Crie um método que realize o saque, esse método deve receber como parâmetro o valor.
            // Observação: O saque não poder ser negativo e nem maior do que o valor permitido.

            // -------------------------------------------------------------------------------

            Console.Write("\r\n ┌────────────────────┐");
            Console.Write("\r\n │ Informe seus dados │");
            Console.Write("\r\n └────────────────────┘\r\n");

            Console.Write(" ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write(" Agência: ");
            string agencia = Console.ReadLine();

            Console.Write(" Número da Conta: ");
            string numeroConta = Console.ReadLine();

            Console.Write(" Nome do Proprietário: ");
            string nomeProprietario = Console.ReadLine();

            ContaBancaria conta = new ContaBancaria(id, agencia, numeroConta, nomeProprietario);

            Console.WriteLine("\n Conta criada com sucesso!");

            while (true)
            {
                Console.WriteLine("\n Escolha uma opção:");
                Console.WriteLine(" 1 - Depósito");
                Console.WriteLine(" 2 - Saque");
                Console.WriteLine(" 3 - Consultar Saldo");
                Console.WriteLine(" 4 - Sair");

                Console.Write(" Opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("\n Informe o valor do depósito: R$");
                        double deposito = double.Parse(Console.ReadLine());
                        conta.Deposito(deposito);
                        break;
                    case 2:
                        Console.Write("\n Informe o valor do saque: R$");
                        double saque = double.Parse(Console.ReadLine());
                        conta.Saque(saque);
                        break;
                    case 3:
                        Console.WriteLine("\r\n -----------------------------------------");
                        Console.Write("\r\n ┌──────────────────────────┐");
                        Console.Write("\r\n │ Consultando seu saldo... │");
                        Console.Write("\r\n └──────────────────────────┘\r\n");

                        Console.WriteLine($"\n Saldo atual: R${conta.Saldo}");
                        break;
                    case 4:
                        Console.WriteLine("\n Saindo...");
                        return;
                    default:
                        Console.WriteLine("\n Opção inválida. Tente novamente.");
                    break;
                }
            }
        }
    }
}