using System;

public class Funcionario
{
    public string nome;
    public string cpf;
    public string email;
    public string senhaAcesso;
    public DateTime dataNascimento;
    public string sexo;

    public int CalcularIdade()
    {
        DateTime dataAtual = DateTime.Today;
        int idade = dataAtual.Year - dataNascimento.Year;

        if (dataAtual < dataNascimento.AddYears(idade))
        {
            idade--;
        }

        return idade;
    }
}