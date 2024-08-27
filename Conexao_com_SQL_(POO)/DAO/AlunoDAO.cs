using MySql.Data.MySqlClient; // <-- Importa a biblioteca necessária para trabalhar com MySQL
using System;
using System.Collections.Generic;
using Conexao_com_SQL__POO_.Models;

namespace Conexao_com_SQL__POO_.DAO
{
    internal class AlunoDAO
    {
        // Método para inserir um novo aluno no banco de dados
        public void Insert(Aluno aluno)
        {
            try
            {
                // Converte a data de nascimento do aluno para o formato "yyyy-MM-dd"
                string dataNascimento = aluno.DataNascimento.ToString("yyyy-MM-dd");

                // SQL para INSERIR um novo aluno na tabela "alunos"
                string sql = "INSERT INTO alunos(nome_alu, cpf_alu, email_alu, telefone_alu, data_nascimento_alu) " +
                             "VALUES(@nome, @cpf, @email, @telefone, @dataNascimento)";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar()); // <-- Cria um comando MySQL para executar a instrução SQL

                // Adiciona os parâmetros ao comando, substituindo os placeholders na SQL
                comando.Parameters.AddWithValue("@nome", aluno.Nome);
                comando.Parameters.AddWithValue("@cpf", aluno.CPF);
                comando.Parameters.AddWithValue("@email", aluno.Email);
                comando.Parameters.AddWithValue("@telefone", aluno.Telefone);
                comando.Parameters.AddWithValue("@dataNascimento", aluno.DataNascimento);
                comando.ExecuteNonQuery(); // <-- Executa o comando de inserção no banco de dados

                Console.WriteLine("\r\nAluno cadastrado com sucesso!");
                Conexao.FecharConexao(); // <-- Fecha a conexão com o banco de dados
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar o aluno! {ex.Message}");
            }
        }

        // Método para deletar um aluno do banco de dados com base no ID
        public void Delete(Aluno aluno)
        {
            try
            {
                // SQL para DELETAR um aluno da tabela "alunos" com base no ID
                string sql = "DELETE FROM alunos WHERE id_alu = @id_aluno";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("@id_aluno", aluno.IdAluno);
                comando.ExecuteNonQuery();

                Console.WriteLine("\r\nAluno excluído com sucesso!");
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"\r\nErro ao excluir o aluno! {ex.Message}");
            }
        }

        // Método para atualizar os dados de um aluno no banco de dados
        public void Update(Aluno aluno)
        {
            try
            {
                // SQL para ATUALIZAR os dados do aluno na tabela "alunos"
                string sql = "UPDATE alunos SET nome_alu = @nome, cpf_alu = @cpf, email_alu = @email, " +
                             "telefone_alu = @telefone WHERE id_alu = @id_aluno";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("@nome", aluno.Nome);
                comando.Parameters.AddWithValue("@cpf", aluno.CPF);
                comando.Parameters.AddWithValue("@email", aluno.Email);
                comando.Parameters.AddWithValue("@telefone", aluno.Telefone);
                comando.Parameters.AddWithValue("@id_aluno", aluno.IdAluno);
                comando.ExecuteNonQuery();

                Console.WriteLine("\r\nAluno atualizado com sucesso!");
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"\r\nErro ao atualizar o aluno! {ex.Message}");
            }
        }

        // Método para listar todos os alunos cadastrados no banco de dados
        public List<Aluno> List()
        {
            List<Aluno> alunos = new List<Aluno>(); // <-- Cria uma lista para armazenar os alunos
            try
            {
                // SQL para SELECIONAR todos os alunos da tabela "alunos", ordenados por nome
                var sql = "SELECT * FROM alunos ORDER BY nome_alu";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                // Executa o comando e obtém os dados retornados pelo banco
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read()) // <-- Itera sobre os dados retornados e cria objetos Aluno para cada linha
                    {
                        Aluno aluno = new Aluno
                        {
                            IdAluno = dr.GetInt32("id_alu"), // <-- Atribui o ID do aluno
                            Nome = dr.GetString("nome_alu"), // <-- Atribui o Nome do aluno
                            Email = dr.GetString("email_alu"), // <-- Atribui o Email do aluno
                            CPF = dr.GetString("cpf_alu"), // <-- Atribui o CPF do aluno
                            Telefone = dr.GetString("telefone_alu"), // <-- Atribui o Telefone do aluno
                            DataNascimento = dr.GetDateTime("data_nascimento_alu") // <-- Atribui a Data de Nascimento do aluno
                        };
                        alunos.Add(aluno);
                    }
                }
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"\r\nErro ao listar os alunos! {ex.Message}");
            }
            return alunos;
        }
    }
}