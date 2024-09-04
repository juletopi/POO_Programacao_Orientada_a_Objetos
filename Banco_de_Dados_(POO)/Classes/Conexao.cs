using MySql.Data.MySqlClient; // <-- Importa a biblioteca necessária para trabalhar com MySQL
using System;

namespace Banco_de_Dados__POO_.Classes
{
    internal class Conexao
    {
        static MySqlConnection conexao; // <-- Objeto responsável por controlar a conexão com a base
        public static MySqlConnection Conectar()
        {
            try
            {
                // Texto-string de conexão com o banco de dados
                string connectionString = "server=localhost;port=3306;uid=root;pwd=123456;database=BancoDeDadosUsuarios";
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