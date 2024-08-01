using System;

namespace Exercicio_04.Classes
{
    public class ContaEstudante : Conta
    {
        public double limiteChequeEspecial;
        public string cpf;
        public string nomeInstituicao;

        public ContaEstudante(int nConta, string agencia, string titular, double saldo, double limiteChequeEspecial, string cpf, string nomeInstituicao)
            : base(nConta, agencia, titular, saldo)
        {
            this.limiteChequeEspecial = limiteChequeEspecial;
            this.cpf = cpf;
            this.nomeInstituicao = nomeInstituicao;
        }

        public override void Sacar(double valor)
        {
            if (valor > saldo + limiteChequeEspecial) 
            {
                Console.WriteLine("Saldo e limite de cheque especial insuficientes!");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso! Seu saldo atual: R${saldo}");
            }
        }

        public new void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Limite de Cheque Especial: R${limiteChequeEspecial}\nCPF: {cpf}\nNome da Instituição: {nomeInstituicao}");
        }
    }
}