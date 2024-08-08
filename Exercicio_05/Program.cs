using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_05.Classes;

namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.WriteLine("Bem-vindo(a)! Por favor, selecione a categoria do veículo: ");
                    Console.WriteLine("1. Passeio");
                    Console.WriteLine("1. Utilitário");
                    Console.WriteLine("1. Ônibus");
                    Console.WriteLine("1. Caminhão\r\n");

                    Console.Write("Opção: ");
                    int opc = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\r\n---------------------------------------------\r\n");

                    // Instância do veículo baseado na opção selecionada pelo usuário
                    Veiculo veiculo;
                    switch (opc)
                    {
                        case 1:
                            veiculo = new Passeio();
                            break;
                        case 2:
                            veiculo = new Utilitario();
                            break;
                        case 3:
                            veiculo = new Onibus();
                            break;
                        case 4:
                            veiculo = new Caminhao();
                            break;
                        default:
                        throw new ArgumentException("Categoria inválida");
                    }

                    Console.Write("Digite a placa do veículo: ");
                    veiculo.Placa = Console.ReadLine();

                    Console.Write("Digite a quantidade de eixos: ");
                    veiculo.QtdEixos = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o tipo (1. Pessoa Física; sem desconto, 2. Pessoa Jurídica; 5% de desconto ou 3. Veículo Oficial; 100% de desconto): ");
                    veiculo.Tipo = Convert.ToInt32(Console.ReadLine());

                    veiculo.CalcularPedagio();
                    veiculo.CalcularDesconto();

                    Console.WriteLine($"\r\nPlaca: {veiculo.Placa}");
                    Console.WriteLine($"Quantidade de Eixos: {veiculo.QtdEixos}");
                    Console.WriteLine($"Tipo: {veiculo.Tipo}");
                    Console.WriteLine($"Preço do Pedágio: {veiculo.PrecoPedagio:C}");
                    Console.WriteLine($"Valor Final com Desconto: {veiculo.ValorFinal:C}\r\n");
                }
                catch (Exception ex) // <-- Exceção que captura e ebibe qualquer exceção que ocorra
                {
                    Console.WriteLine($"\r\nErro: {ex.Message}");
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