using System;

public class ContaBancaria
{
    public int Id { get; set; }
    public string Agencia { get; set; }
    public string NumeroConta { get; set; }
    public string NomeProprietario { get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria(int id, string agencia, string numeroConta, string nomeProprietario)
    {
        Id = id;
        Agencia = agencia;
        NumeroConta = numeroConta;
        NomeProprietario = nomeProprietario;
        Saldo = 0.0;
    }

    public void Deposito(double valor)
    {
        Console.WriteLine("\r\n -----------------------------------------");
        Console.Write("\r\n ┌──────────┐");
        Console.Write("\r\n │ Depósito │");
        Console.Write("\r\n └──────────┘\r\n");

        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($" Depósito de R${valor} realizado com sucesso. Novo saldo: R${Saldo}");
        }
        else
        {
            Console.WriteLine(" O valor do depósito deve ser maior que zero.");
        }
    }

    public void Saque(double valor)
    {
        Console.WriteLine("\r\n -----------------------------------------");
        Console.Write("\r\n ┌───────┐");
        Console.Write("\r\n │ Saque │");
        Console.Write("\r\n └───────┘\r\n");

        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($" Saque de R${valor} realizado com sucesso. Novo saldo: R${Saldo}");
        }
        else if (valor <= 0)
        {
            Console.WriteLine(" O valor do saque deve ser maior que zero.");
        }
        else
        {
            Console.WriteLine(" Saldo insuficiente para realizar o saque.");
        }
    }
}
