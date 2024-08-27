using System;
using System.Collections.Generic;
using Conexao_com_SQL__POO_.DAO;
using Conexao_com_SQL__POO_.Models;

namespace Conexao_com_SQL__POO_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia necessária para interagir com o banco de dados
            AlunoDAO alunoDAO = new AlunoDAO();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\r\nMENU DE OPÇÕES:");
                Console.WriteLine("1. Cadastrar Aluno");
                Console.WriteLine("2. Listar Alunos");
                Console.WriteLine("3. Atualizar Aluno");
                Console.WriteLine("4. Deletar Aluno");
                Console.WriteLine("5. Sair");
                Console.Write("\r\nEscolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarAluno(alunoDAO);
                        break;
                    case "2":
                        ListarAlunos(alunoDAO);
                        break;
                    case "3":
                        AtualizarAluno(alunoDAO);
                        break;
                    case "4":
                        DeletarAluno(alunoDAO);
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("\r\nOpção inválida. Pressione Enter para tentar novamente.");
                        Console.ReadLine();
                    break;
                }
            }
        }

        // Método para cadastrar um novo aluno
        static void CadastrarAluno(AlunoDAO alunoDAO)
        {
            Console.WriteLine("\r\nCadastro de Aluno:");

            Aluno aluno = new Aluno();

            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("CPF: ");
            aluno.CPF = Console.ReadLine();

            Console.Write("Email: ");
            aluno.Email = Console.ReadLine();

            Console.Write("Telefone: ");
            aluno.Telefone = Console.ReadLine();

            Console.Write("Data de Nascimento (dd/MM/yyyy): ");
            aluno.DataNascimento = DateTime.Parse(Console.ReadLine());

            alunoDAO.Insert(aluno); // <-- Chama o método do DAO para cadastrar o aluno
            Console.WriteLine("\r\nAluno cadastrado com sucesso! Pressione Enter para continuar.");
            Console.ReadLine();
        }

        // Método para listar todos os alunos cadastrados
        static void ListarAlunos(AlunoDAO alunoDAO)
        {
            Console.WriteLine("\r\nLista de Alunos:");

            List<Aluno> alunos = alunoDAO.List();
            if (alunos.Count > 0)
            {
                foreach (var aluno in alunos)
                {
                    Console.WriteLine($"ID: {aluno.IdAluno}, Nome: {aluno.Nome}, Email: {aluno.Email}");
                }
            }
            else
            {
                Console.WriteLine("\r\nNenhum aluno cadastrado.");
            }
            Console.WriteLine("\r\nPressione Enter para continuar.");
            Console.ReadLine();
        }

        // Método para atualizar as informações de um aluno existente
        static void AtualizarAluno(AlunoDAO alunoDAO)
        {
            Console.WriteLine("\r\nAtualizar Aluno:");

            Console.Write("ID do Aluno a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());

            Aluno aluno = new Aluno
            {
                IdAluno = id
            };

            Console.Write("Novo Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Novo CPF: ");
            aluno.CPF = Console.ReadLine();

            Console.Write("Novo Email: ");
            aluno.Email = Console.ReadLine();

            Console.Write("Novo Telefone: ");
            aluno.Telefone = Console.ReadLine();

            alunoDAO.Update(aluno);
            Console.WriteLine("\r\nAluno atualizado com sucesso! Pressione Enter para continuar.");
            Console.ReadLine();
        }

        // Método para deletar um aluno com base no ID
        static void DeletarAluno(AlunoDAO alunoDAO)
        {
            Console.WriteLine("\r\nDeletar Aluno:");

            Console.Write("ID do Aluno a ser deletado: ");
            int id = int.Parse(Console.ReadLine());

            Aluno aluno = new Aluno { IdAluno = id };
            alunoDAO.Delete(aluno);
            Console.WriteLine("\r\nAluno deletado com sucesso! Pressione Enter para continuar.");
            Console.ReadLine();
        }
    }
}