using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Alunos__POO_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CADASTRO DE ALUNO - IMPLEMENTANDO LISTAS NA CRIAÇÃO DE CLASSES E ATRIBUTOS

            // Faça um algoritmo de "Cadastro de Alunos". Nesse algoritmo terá uma interação com o usuário
            // onde será perguntado se ele deseja cadastrar um aluno com Nome, CPF e Email até que ele
            // selecione que não deseja mais cadastrar nenhum aluno, assim finalizando o cadastro e
            // mostrando uma lista de todos cadastrados com seus respectivos Nomes, CPFs e Emails.

            List<Aluno> alunos = new List<Aluno>(); // <-- Lista para armazenar os alunos cadastrados

            Console.Write("\r\n ┌────────────────────┐");
            Console.Write("\r\n │ Cadastro de Alunos │");
            Console.Write("\r\n └────────────────────┘\r\n");

            while (true)
            {
                Console.WriteLine("\n Deseja cadastrar um aluno? (s/n)");
                string resposta = Console.ReadLine();

                if (resposta.ToLower() != "s")
                {
                    break;
                }

                Aluno aluno = new Aluno(); // <-- Cria um novo objet "Aluno"

                Console.Write("\n Nome do(a) aluno: ");
                aluno.nome = Console.ReadLine();

                Console.Write(" CPF do aluno: ");
                aluno.cpf = Console.ReadLine();

                Console.Write(" Email do aluno: ");
                aluno.email = Console.ReadLine();

                alunos.Add(aluno); // <-- Adiciona o aluno à lista de alunos cadastrados
            }

            Console.WriteLine("\r\n -----------------------------------------");
            Console.Write("\r\n ┌──────────────────────────────┐");
            Console.Write("\r\n │ Lista de alunos cadastrados: │");
            Console.Write("\r\n └──────────────────────────────┘\r\n");
            foreach (var aluno in alunos) // Para cada aluno na lista de alunos cadastrados...
            {
                Console.WriteLine($"\n Nome: {aluno.nome}, CPF: {aluno.cpf}, Email: {aluno.email}"); // ...exibe na tela o nome, CPF e email do aluno
            }
            Console.WriteLine("\r\n -----------------------------------------");
            Console.ReadKey();
        }
    }
}