using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class Program
    {
        static List<Produto> produtos = new List<Produto>(); // <-- Lista de produtos
        static void Main(string[] args)
        {
            // 1. Crie uma classe Produto que possui os seguintes atributos: Código do produto, descrição
            // (o nome do produto), unidade (LT, CX, KG, UN, MT), preço, quantidade em estoque.

            // a) O preço de um produto só pode ser valores maiores de zero;
            // b) O tipo de unidade do produto deve estar dentro das opções listadas;
            // Obs. A verificação do preço e do tipo de unidade deve ser implementada na classe Produto.

            // 2. Crie uma iteração com o usuário que permita o cadastro de produto e a opção de listagem de
            // todos os produtos cadastrados. Obs. Os produtos devem ser inseridos em uma lista de objetos.

            // 3. Crie uma opção para a remoção de um produto da lista, o usuário deve
            // informar o código do produto e o sistema deve removê-lo na lista.

            // -------------------------------------------------------------------------------

            Console.Write("\r\n ┌──────────────────────┐");
            Console.Write("\r\n │ Cadastro de Produtos │");
            Console.Write("\r\n └──────────────────────┘ \r\n");

            while (true)
            {
                Console.WriteLine("\r\n -----------------------------------------");
                Console.WriteLine("\n Escolha uma opção:");
                Console.WriteLine(" 1 - Cadastrar novo produto");
                Console.WriteLine(" 2 - Listar produtos cadastrados");
                Console.WriteLine(" 3 - Remover produto");
                Console.WriteLine(" 4 - Sair");
                Console.Write("\n Opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarProduto(); // <-- Chamada do método para cadastrar um novo produto
                        break;
                    case "2":
                        ListarProdutos(); // <-- Chamada do método para listar produtos já cadastrados
                        break;
                    case "3":
                        RemoverProduto(); // <-- Chamada do método para remover um produto
                        break;
                    case "4":
                        Console.WriteLine(" Fechando o programa!");
                        return;
                    default:
                        Console.WriteLine("\n Opção inválida! Por favor, escolha uma opção válida.");
                        Console.WriteLine(" Aperte ENTER para continuar...");
                        break;
                }
                Console.ReadKey();
            }
        }

        static void CadastrarProduto()
        {
            int codigo;

            // Verifica se o usuário insere somente números para o código
            while (true)
            {
                Console.Write("\n Digite o código do produto (somente números): ");
                if (int.TryParse(Console.ReadLine(), out codigo))
                {
                    if (codigo > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n Código inválido! O código deve ser um número inteiro maior que zero.");
                    }
                }
                else
                {
                    Console.WriteLine("\n Caractere inválido! Por favor, digite apenas números.");
                }
            }

            // Verifica se o código já existe na lista de produtos
            while (produtos.Any(p => p.Codigo == codigo))
            {
                Console.WriteLine("\n Já existe um produto cadastrado com este código! Por favor, escolha outro código. \n");

                // Solicita novamente que o usuário digite o código do produto
                Console.Write(" Digite o código do produto: ");
                if (!int.TryParse(Console.ReadLine(), out codigo) || codigo <= 0)
                {
                    Console.WriteLine("\n Código inválido! Por favor, digite apenas números e um código maior ou igual a zero. \n");
                }
            }

            Console.Write(" Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write(" Digite a unidade do produto (LT, CX, KG, UN, MT): ");
            string unidade = Console.ReadLine().ToUpper();
            while (!Produto.ValidarUnidade(unidade))
            {
                Console.WriteLine("\n Unidade inválida! As unidades permitidas são: LT, CX, KG, UN, MT \n");
                Console.Write(" Digite a unidade do produto (LT, CX, KG, UN, MT): ");
                unidade = Console.ReadLine().ToUpper();
            }

            double preco;
            // Verifica se o preço do produto é um número válido maior que zero
            while (true)
            {
                Console.Write(" Digite o preço do produto: ");
                if (double.TryParse(Console.ReadLine(), out preco) && preco > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\n Preço inválido! O preço deve ser um número inteiro maior que zero. \n");
                }
            }

            int quantidadeEstoque;
            // Verifica se a quantidade em estoque do produto é um número válido maior ou igual a zero
            while (true)
            {
                Console.Write(" Digite a quantidade em estoque do produto: ");
                if (int.TryParse(Console.ReadLine(), out quantidadeEstoque) && quantidadeEstoque >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\n Quantidade em estoque inválida! A quantidade deve ser um número inteiro maior ou igual a zero. \n");
                }
            }

            produtos.Add(new Produto(codigo, nome, unidade, preco, quantidadeEstoque));
            Console.WriteLine("\n Produto cadastrado com sucesso!");
            Console.WriteLine(" Aperte ENTER para continuar...");
        }

        static void ListarProdutos()
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("\n Nenhum produto cadastrado!");
                Console.WriteLine(" Aperte ENTER para continuar...");
            }
            else
            {
                Console.WriteLine("\n Produtos cadastrados: \n");
                foreach (var produto in produtos)
                {
                    Console.WriteLine($" Código: {produto.Codigo} | Nome: {produto.Nome} | Unidade: {produto.Unidade} | Preço: R${produto.Preco} | Quantidade em estoque: {produto.QuantidadeEstoque}");
                }
                Console.WriteLine("\n Aperte ENTER para continuar...");
            }
        }

        static void RemoverProduto()
        {
            int codigo;

            // Verifica se o usuário insere somente números para o código na hora de removê-los
            while (true)
            {
                Console.Write("\n Digite o código do produto que deseja remover: ");
                if (int.TryParse(Console.ReadLine(), out codigo))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\n Caractere inválido! Por favor, digite apenas números para o código. \n");
                }
            }

            Produto produtoRemover = produtos.Find(p => p.Codigo == codigo);
            if (produtoRemover != null)
            {
                produtos.Remove(produtoRemover);
                Console.WriteLine("\n Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("\n Produto não encontrado!");
            }

            Console.WriteLine(" Aperte ENTER para continuar...");
        }

    }
}