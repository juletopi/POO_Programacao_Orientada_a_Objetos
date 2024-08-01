using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04.Classes
{
    public class Conta
    {
        public int nConta;
        public string agencia;
        public string titular;
        public double saldo;

        public Conta(int nConta, string agencia, string titular, double saldo)
        {
            this.nConta = nConta;
            this.agencia = agencia;
            this.titular = titular;
            this.saldo = saldo;
        }

        public virtual void Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else 
            {
                Console.WriteLine($"Saque de R${valor} realizado com sucesso! Seu saldo atual: R${saldo}");
            }
        }

        public virtual void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado com sucesso! Seu saldo atual: R${saldo}");
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Número da Conta: {nConta}\nAgência: {agencia}\nTitular: {titular}\nSaldo: R${saldo}");
        }
    }
}