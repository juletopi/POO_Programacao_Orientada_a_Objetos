using System;
using Banco_de_Dados__POO_.Classes;
using System.Collections.Generic;

namespace Banco_de_Dados__POO_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia necessária para interagir com o banco de dados
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\r\nMENU - CADASTRO DE USUÁRIOS NO BANCO DE DADOS");
                Console.WriteLine("1 - Cadastrar Usuário");
                Console.WriteLine("2 - Listar Usuários");
                Console.WriteLine("3 - Atualizar Usuário");
                Console.WriteLine("4 - Deletar Usuário");
                Console.WriteLine("5 - Sair");
                Console.Write("\r\nEscolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarUsuario(usuarioDAO);
                        break;
                    case "2":
                        ListarUsuarios(usuarioDAO);
                        break;
                    case "3":
                        AtualizarUsuario(usuarioDAO);
                        break;
                    case "4":
                        DeletarUsuario(usuarioDAO);
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

        // Método para cadastrar um novo usuário
        static void CadastrarUsuario(UsuarioDAO usuarioDAO)
        {
            Console.WriteLine("\r\nCadastro de Usuário:");

            Usuario usuario = new Usuario();

            Console.Write("Nome: ");
            usuario.Nome = Console.ReadLine();

            Console.Write("Email: ");
            usuario.Email = Console.ReadLine();

            try
            {
                usuarioDAO.CadastrarUsuario(usuario); // <-- Chama o método do DAO para cadastrar o usuário
                Console.WriteLine("\r\nUsuário cadastrado com sucesso! Pressione Enter para continuar.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\r\nErro ao cadastrar usuário: {ex.Message}");
            }
            Console.ReadLine();
        }

        // Método para listar todos os usuários cadastrados
        static void ListarUsuarios(UsuarioDAO usuarioDAO)
        {
            Console.WriteLine("\r\nLista de Usuários:");

            List<Usuario> usuarios = usuarioDAO.ListarUsuarios();

            if (usuarios.Count == 0)
            {
                Console.WriteLine("\r\nNenhum usuário cadastrado no sistema.");
            }
            else
            {
                foreach (var usuario in usuarios)
                {
                    Console.WriteLine($"ID: {usuario.ID}, Nome: {usuario.Nome}, Email: {usuario.Email}");
                }
            }
            Console.WriteLine("\r\nPressione Enter para continuar.");
            Console.ReadLine();
        }

        // Método para atualizar as informações de um usuário existente
        static void AtualizarUsuario(UsuarioDAO usuarioDAO)
        {
            Console.WriteLine("\r\nAtualizar Usuário:");

            Console.Write("ID do usuário a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());

            Usuario usuario = new Usuario
            {
                ID = id
            };

            Console.Write("Novo Nome: ");
            usuario.Nome = Console.ReadLine();

            Console.Write("Novo Email: ");
            usuario.Email = Console.ReadLine();

            try
            {
                usuarioDAO.AtualizarUsuario(usuario); // Chama o método do DAO para atualizar o usuário
                Console.WriteLine("\r\nUsuário atualizado com sucesso! Pressione Enter para continuar.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\r\nErro ao atualizar usuário: {ex.Message}");
            }
            Console.ReadLine();
        }

        // Método para deletar um usuário com base no ID
        static void DeletarUsuario(UsuarioDAO usuarioDAO)
        {
            Console.WriteLine("\r\nDeletar Usuário:");

            Console.Write("ID do usuário a ser deletado: ");
            int id = int.Parse(Console.ReadLine());

            try
            {
                usuarioDAO.DeletarUsuario(id); // <-- Chama o método do DAO para deletar o usuário
                Console.WriteLine("\r\nUsuário deletado com sucesso! Pressione Enter para continuar.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\r\nErro ao deletar usuário: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}