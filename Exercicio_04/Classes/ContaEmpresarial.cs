using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04.Classes
{
    public class ContaEmpresarial : Conta
    {
        public double anuidade;
        public double limiteEmprestimo;
        public double totalEmprestimo;

        public ContaEmpresarial(int nConta, string agencia, string titular, double saldo, double anuidade, double limiteEmprestimo)
            : base(nConta, agencia, titular, saldo)
        {
            this.anuidade = anuidade;
            this.limiteEmprestimo = limiteEmprestimo;
            this.totalEmprestimo = 0;
        }

        public override void Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                if (valor > 5000)
                {
                    valor += 5; // Dedução de R$5 para saques acima de R$5000
                }
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso! Seu saldo atual: R${saldo}");
            }
        }

        public void FazerEmprestimo(double valor)
        {
            if (valor > limiteEmprestimo - totalEmprestimo)
            {
                Console.WriteLine("Limite de empréstimo excedido!");
            }
            else
            {
                totalEmprestimo += valor;
                saldo += valor;
                Console.WriteLine($"Empréstimo de R${valor} realizado com sucesso! Seu total de empréstimo: R${totalEmprestimo}");
            }
        }

        public override void Depositar(double valor)
        {
            if (valor > 5000)
            {
                valor -= 5; // <-- Dedução de R$5 para depósitos acima de R$5000
            }

            saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado com sucesso! Seu saldo atual: R${saldo}");
        }

        public new void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Anuidade: R${anuidade}\nLimite de Empréstimo: R${limiteEmprestimo}\nTotal de Empréstimo: R${totalEmprestimo}");
        }
    }
}