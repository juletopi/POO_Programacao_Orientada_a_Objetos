using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisaoPOO2.Classes;

namespace RevisaoPOO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de uma lista de objetos da classe Alunos
            List<Alunos> listAlunos = new List<Alunos>();

            // Criação de objetos da classe Alunos
            Alunos aluno1 = new Alunos("Rafaela", 048, "625552980-20", "rafa022@gmail.com", new DateTime(2001, 09, 12));
            Alunos aluno2 = new Alunos("Júlio", 027, "073743612-38", "julio03@gmail.com", new DateTime(2003, 09, 17));
            Alunos aluno3 = new Alunos("Breno", 089, "390900176-46", "brenopd@gmail.com", new DateTime(2005, 09, 01));
            Alunos aluno4 = new Alunos("Iberê", 021, "192236608-36", "tenoriomm@gmail.com", new DateTime(1998, 11, 21));
            Alunos aluno5 = new Alunos("João", 055, "902630047-18", "jaovictor001@gmail.com", new DateTime(1991, 07, 03));

            // Adicionando os objetos Alunos à lista
            listAlunos.Add(aluno1);
            listAlunos.Add(aluno2);
            listAlunos.Add(aluno3);
            listAlunos.Add(aluno4);
            listAlunos.Add(aluno5);

            // Exibindo todos os alunos da lista
            Console.WriteLine("Exibindo a lista de alunos:\r\n");
            foreach (Alunos alunos in listAlunos)
            {
                Console.WriteLine(alunos.ToString());
            }
            Console.WriteLine("\r\n---------------------------------------------\r\n");

            // Buscando e exibindo um aluno específico pela matrícula
            Console.WriteLine("Exibindo a busca por um aluno específico:\r\n");
            Alunos search = listAlunos.Find(x => x.matricula == 027);
            Console.WriteLine(search.ToString());
            Console.WriteLine("\r\n---------------------------------------------\r\n");

            // Buscando e exibindo alunos com número de matrícula maior que 40
            Console.WriteLine("Exibindo a lista de alunos com o número de matrícula maior que 40:\r\n");
            List<Alunos> searchList = listAlunos.Where(x => x.matricula > 40).ToList();
            foreach (Alunos alunos in searchList)
            {
                Console.WriteLine(alunos.ToString());
            }
            Console.WriteLine("\r\n---------------------------------------------\r\n");

            // Buscando e exibindo o maior número de matrícula
            Console.WriteLine("Exibindo o maior número de matrícula:\r\n");
            int b = listAlunos.Max(x => x.matricula);
            Console.WriteLine(b);
            Console.WriteLine("\r\n---------------------------------------------\r\n");

            // Ordenando e exibindo a lista de alunos pelo número de matrícula em ordem crescente
            Console.WriteLine("Exibindo a lista de alunos ordenados a partir do número de matrícula em ordem crescente:\r\n");
            List<Alunos> ordenedList = listAlunos.OrderBy(x => x.matricula).ToList();
            foreach (Alunos alunos in ordenedList)
            {
                Console.WriteLine(alunos.ToString());
            }
            Console.WriteLine("\r\n---------------------------------------------\r\n");

            // Buscando e exibindo alunos cujos nomes contêm a letra 'e'
            Console.WriteLine("Exibindo a busca por alunos com a letra 'e' em seus nomes:\r\n");
            List<Alunos> distinctiveList = listAlunos.Where(x => x.nome.ToLower().Contains("e")).ToList();
            foreach (Alunos alunos in distinctiveList)
            {
                Console.WriteLine(alunos.ToString());
            }
            Console.WriteLine("\r\n---------------------------------------------\r\n");

            // Buscando e exibindo alunos cujos nomes começam com a letra 'j'
            Console.WriteLine("Exibindo a busca por alunos com nomes que começam com a letra 'j':\r\n");
            List<Alunos> startsWithList = listAlunos.Where(x => x.nome.ToLower().StartsWith("j")).ToList();
            foreach (Alunos alunos in startsWithList)
            {
                Console.WriteLine(alunos.ToString());
            }

            Console.ReadKey();
        }
    }
}