using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie uma classe Gabarito, a qual possui como atributo uma lista de alternativas corretas para cada questões.

            // A classe deve possui um método RespostaQuestao que recebe como parâmetro o número de uma questão e
            // retorna a sua resposta correta, proveniente de um gabarito.  

            // Escreva uma classe Prova em que cada objeto representa uma prova feita por um aluno. 
            // Cada prova possui um gabarito como atributo, que representa o gabarito correto de cada 
            // questão da prova (gabarito da classe Gabarito). 

            // A classe prova possui um atributo do tipo lista que representa as respostas data pelo aluno. 
            // Cada resposta do aluno deve estar entre as alternativas A até E, o gabarito da classe 
            // gabarito deve seguir essa mesma característica. 

            // Para cada prova, a nota máxima deve ser 10 pontos que devem ser divididas 
            // em valores iguais para cada questão. Esta classe deverá controlar as questões respondidas pelo aluno. 
            // Para isto, a classe deve implementar os métodos: 

            // • 1. Construtor: recebe como parâmetro um objeto da classe Gabarito contendo o gabarito da prova; 
            // • 2. RespostaAluno: recebe como parâmetro a resposta dada pelo aluno a uma questão;
            // este método não recebe entre os parâmetros o número da questão, ele mesmo deves estabelecer um
            // controle interno de modo que as questões sejam inseridas sequencialmente, ou seja, a primeira vez que o
            // método é chamado, insere a primeira questão, a segunda, insere a segunda questão, e assim por diante. 
            // • 3. Acertos: retorna à quantidade de questões que o aluno acertou; 
            // • 4. Nota: retorna a nota que o aluno tirou na prova; 
            // • 5. Maior: recebe como parâmetro um outro objeto da classe Prova e retorna a nota do aluno que acertou mais questões;
            // se houver empate, retorna a maior nota; se houver empate novamente, retorna a nota do aluno representado no objeto corrente.

            // -------------------------------------------------------------------------------

            // Exemplo de uso
            Console.Write("\r\n ┌────────────────────────────────────────────┐");
            Console.Write("\r\n │ Prova dos Alunos - Interação com o usuário │");
            Console.Write("\r\n └────────────────────────────────────────────┘\r\n");

            // Criando um gabarito
            char[] respostas = { 'A', 'B', 'C', 'D', 'E' };
            Gabarito gabarito = new Gabarito(respostas);

            // Criando uma prova com o gabarito
            Prova prova = new Prova(gabarito);

            while (true)
            {
                Console.WriteLine("\r\n -----------------------------------------");
                Console.WriteLine("\n Menu:");
                Console.WriteLine(" 1 - Cadastrar aluno e suas respostas");
                Console.WriteLine(" 2 - Listar alunos e suas notas");
                Console.WriteLine(" 3 - Sair");
                Console.Write("\n Opção escolhida: ");
                string opcao = Console.ReadLine();

                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("\n Digite o nome do aluno: ");
                        string nomeAluno = Console.ReadLine();
                        char[] respostasAluno = new char[gabarito.TotalQuestoes()];
                        for (int i = 0; i < gabarito.TotalQuestoes(); i++)
                        {
                            Console.Write(" Digite a resposta da questão " + (i + 1) + ": ");
                            respostasAluno[i] = char.ToUpper(Console.ReadKey().KeyChar);
                            Console.WriteLine();
                        }
                        prova.RespostaAluno(respostasAluno);
                        Console.WriteLine("\n Aluno e suas respostas cadastrados com sucesso!\n");
                    break;

                    case "2":
                        List<string> alunos = prova.ListarAlunos();
                        foreach (string aluno in alunos)
                        {
                            Console.WriteLine(aluno);
                        }
                        Console.WriteLine("\n Maior nota: " + prova.Maior() + "\n");
                        Console.WriteLine(gabarito.ListarGabarito());
                    break;

                    case "3":
                        Console.WriteLine("\n Fechando o sistema. Até logo!");
                    return;

                    default:
                        Console.WriteLine("\n Opção inválida. Por favor, escolha uma opção válida!");
                    break;
                }
                Console.WriteLine(" Aperte ENTER para continuar...");
                Console.ReadKey();
            }
        }
    }
}