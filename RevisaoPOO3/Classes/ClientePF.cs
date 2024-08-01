using System;

namespace RevisaoPOO3.Classes
{
    public class ClientePF : Cliente // <-- Classe Derivada "filho" ClientePF
    {
        // Propriedades específicas para clientes pessoa física (PF)
        public string CPF { get; set; }
        public string FormacaoAcademica { get; set; }

        // Implementação do método para cadastrar informações do cliente PF
        public override void Cadastrar()
        {
            Console.Write("Digite o ID: ");
            ID = Console.ReadLine();

            Console.Write("Digite o Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Digite o Email: ");
            Email = Console.ReadLine();

            Console.Write("Digite o Telefone: ");
            Telefone = Console.ReadLine();

            Console.Write("Digite o CPF: ");
            CPF = Console.ReadLine();

            Console.Write("Digite a Formação Acadêmica: ");
            FormacaoAcademica = Console.ReadLine();
        }

        // Método para exibir informações do cliente PF
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes(); // <-- Chamando o método da classe base para exibir informações comuns
            Console.WriteLine($"CPF: {CPF} - Formação Acadêmica: {FormacaoAcademica}");
        }
    }
}