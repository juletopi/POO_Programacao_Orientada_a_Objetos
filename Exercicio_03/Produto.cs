using System;
using System.Collections.Generic;

public class Produto
{
    private int codigo;
    private string nome;
    private string unidade;
    private double preco;
    private int quantidadeEstoque;

    public int Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Unidade
    {
        get { return unidade; }
        set { unidade = value; }
    }

    public double Preco
    {
        get { return preco; }
        set { preco = value; }
    }

    public int QuantidadeEstoque
    {
        get { return quantidadeEstoque; }
        set { quantidadeEstoque = value; }
    }

    public Produto(int codigo, string nome, string unidade, double preco, int quantidadeEstoque)
    {
        Codigo = codigo;
        Nome = nome;
        Unidade = unidade;
        Preco = preco;
        QuantidadeEstoque = quantidadeEstoque;
    }

    public static bool ValidarPreco(double preco)
    {
        return preco > 0;
    }

    public static bool ValidarUnidade(string unidade)
    {
        List<string> unidadesPermitidas = new List<string> { "LT", "CX", "KG", "UN", "MT" };
        return unidadesPermitidas.Contains(unidade);
    }
}