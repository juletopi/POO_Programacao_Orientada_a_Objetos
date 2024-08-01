using System;

namespace RevisaoPOO3.Classes
{
    public class ClientePJ : Cliente // <-- Classe Derivada "filho" ClientePJ
    {
        // Propriedades específicas para clientes pessoa jurídica (PJ)
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

        // Implementação do método para cadastrar informações do cliente PJ
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

            Console.Write("Digite o CNPJ: ");
            CNPJ = Console.ReadLine();

            Console.Write("Digite a Razão Social: ");
            RazaoSocial = Console.ReadLine();

            Console.Write("Digite o Nome Fantasia: ");
            NomeFantasia = Console.ReadLine();
        }

        // Método para exibir informações do cliente PJ
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes(); // <-- Chamando o método da classe base para exibir informações comuns
            Console.WriteLine($"CNPJ: {CNPJ} - Razão Social: {RazaoSocial} - Nome Fantasia: {NomeFantasia}");
        }
    }
}