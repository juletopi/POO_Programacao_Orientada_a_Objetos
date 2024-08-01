using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_04.Classes;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ContaEstudante
            ContaEstudante contaEstudante = new ContaEstudante(12345, "001", "Garibaldo Deovaldi", 1500, 500, "123.456.789-10", "Universidade Pamonha");
            contaEstudante.ExibirInfo();
            contaEstudante.Depositar(200);
            contaEstudante.Sacar(1800);
            contaEstudante.Sacar(250);
            Console.WriteLine("\r\n---------------------------------------------\r\n");

            // ContaEmpresarial
            ContaEmpresarial contaEmpresarial = new ContaEmpresarial(67890, "002", "Empresa Entulho Roxo", 5000, 1000, 50000);
            contaEmpresarial.ExibirInfo();
            contaEmpresarial.Depositar(6000);
            contaEmpresarial.FazerEmprestimo(20000);
            contaEmpresarial.FazerEmprestimo(35000); // <-- Falha
            contaEmpresarial.Sacar(1000);

            Console.ReadKey();
        }
    }
}