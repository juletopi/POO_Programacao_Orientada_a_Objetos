using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPOO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                try // <-- Início do bloco 'try-catch' para capturar 'Exceções'
                {
                    Console.Write("Digite o primeiro número: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    int resultado = num1 / num2;

                    Console.WriteLine($"\r\nResultado: {resultado}");
                }
                catch (DivideByZeroException) // <-- Exceção lançada quando ocorre uma tentativa de divisão por zero.
                {
                    Console.WriteLine("\r\nErro: Divisão por zero não é permitida!");
                }
                catch (FormatException) // Exceção lançada quando a conversão de um tipo de dado para outro falha.
                {
                    Console.WriteLine("\r\nErro: Entrada inválida. Por favor, insira um número inteiro!");
                }

                Console.Write("\r\nDeseja realizar outra operação? (s/n): ");
                string resposta = Console.ReadLine().ToLower();
                Console.WriteLine("\r\n---------------------------------------------\r\n");

                if (resposta != "s")
                {
                    continuar = false;
                }
            }
            Console.WriteLine("Finalizando a aplicação...");

            Console.ReadKey();
        }
    }
}