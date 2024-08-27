using System;
using MySql.Data.MySqlClient; // <-- Importa a biblioteca necessária para trabalhar com MySQL

namespace Conexao_com_SQL__POO_
{
    public static class Conexao
    {
        static MySqlConnection conexao; // <-- Objeto responsável por controlar a conexão com a base
        public static MySqlConnection Conectar()
        {
            try
            {
                // Texto-string de conexão com o banco de dados
                string connectionString = "server=localhost;port=3306;uid=root;pwd=sua_senha_aqui;database=nome_do_seu_banco_de_dados_aqui";
                conexao = new MySqlConnection(connectionString);
                conexao.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\r\nErro ao realizar a conexão com a base de dados!");
            }
            return conexao;
        }

        // Método para fechar a conexão com o banco de dados
        public static void FecharConexao()
        {
            conexao.Close();
        }
    }
}