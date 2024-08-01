using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisaoPOO3.Classes;

namespace RevisaoPOO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de ClientePJ e cadastrando as informações
            ClientePJ clientePJ = new ClientePJ();
            Console.WriteLine("Cadastro de Cliente PJ:");
            clientePJ.Cadastrar();
            Console.WriteLine("\r\n---------------------------------------------\r\n");

            // Criando uma instância de ClientePF e cadastrando as informações
            ClientePF clientePF = new ClientePF();
            Console.WriteLine("Cadastro de Cliente PF:");
            clientePF.Cadastrar();
            Console.WriteLine("\r\n---------------------------------------------\r\n");

            // Exibindo as informações cadastradas para o Cliente PJ
            Console.WriteLine("Informações do Cliente PJ:");
            clientePJ.ExibirInformacoes();
            Console.WriteLine("\r\n---------------------------------------------\r\n");

            // Exibindo as informações cadastradas para o Cliente PF
            Console.WriteLine("Informações do Cliente PF:");
            clientePF.ExibirInformacoes();
            Console.WriteLine("\r\n---------------------------------------------\r\n");

            Console.ReadKey();
        }
    }
}