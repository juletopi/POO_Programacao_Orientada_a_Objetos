using MySql.Data.MySqlClient; // <-- Importa a biblioteca necessária para trabalhar com MySQL
using System;
using System.Collections.Generic;

namespace Banco_de_Dados__POO_.Classes
{
    internal class UsuarioDAO
    {
        // Método para cadastrar um novo usuário no banco de dados
        public void CadastrarUsuario(Usuario usuario)
        {
            try
            {
                // SQL para INSERIR um novo usuário na tabela "usuarios"
                string sql = "INSERT INTO usuarios (Nome, Email) VALUES (@Nome, @Email)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar()); // <-- Cria um comando MySQL para executar a instrução SQL

                // Adiciona os parâmetros ao comando, substituindo os placeholders na SQL
                comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                comando.Parameters.AddWithValue("@Email", usuario.Email);
                comando.ExecuteNonQuery(); // <-- Executa o comando de inserção no banco de dados

                Console.WriteLine("\r\nUsuário cadastrado com sucesso!");
                Conexao.FecharConexao(); // <-- Fecha a conexão com o banco de dados
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar o usuário! {ex.Message}");
            }
        }

        // Método para atualizar os dados de um usuário no banco de dados
        public void AtualizarUsuario(Usuario usuario)
        {
            try
            {
                // SQL para ATUALIZAR os dados do usuário na tabela "usuarios"
                string sql = "UPDATE usuarios SET Nome = @Nome, Email = @Email WHERE Id = @Id";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                comando.Parameters.AddWithValue("@Email", usuario.Email);
                comando.Parameters.AddWithValue("@Id", usuario.ID);
                comando.ExecuteNonQuery();

                Console.WriteLine("\r\nUsuário atualizado com sucesso!");
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"\r\nErro ao atualizar o usuário! {ex.Message}");
            }
        }

        // Método para deletar um usuário do banco de dados com base no ID
        public void DeletarUsuario(int id)
        {
            try
            {
                // SQL para DELETAR um usuário da tabela "usuarios"
                string sql = "DELETE FROM usuarios WHERE Id = @Id";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("@Id", id);
                comando.ExecuteNonQuery();

                Console.WriteLine("\r\nUsuário excluído com sucesso!");
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"\r\nErro ao excluir o usuário! {ex.Message}");
            }
        }

        // Método para listar todos os usuários cadastrados no banco de dados
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>(); // <-- Cria uma lista para armazenar os usuários
            try
            {
                // SQL para SELECIONAR todos os usuários da tabela "usuarios", ordenados por nome
                string sql = "SELECT * FROM usuarios ORDER BY Nome";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                // Executa o comando e obtém os dados retornados pelo banco
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read()) // <-- Itera sobre os dados retornados e cria objetos Usuario para cada linha
                    {
                        Usuario usuario = new Usuario
                        {
                            ID = dr.GetInt32("Id"), // <-- Atribui o ID do usuário
                            Nome = dr.GetString("Nome"), // <-- Atribui o Nome do usuário
                            Email = dr.GetString("Email") // <-- Atribui o Email do usuário
                        };
                        usuarios.Add(usuario);
                    }
                }
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"\r\nErro ao listar os usuários! {ex.Message}");
            }
            return usuarios;
        }
    }
}