using System;

namespace ProvaAlunos
{
    public class Gabarito
    {
        public char[] respostas;

        // Construtor
        public Gabarito(char[] respostas)
        {
            this.respostas = respostas;
        }

        // Retorna a resposta correta de uma questão
        public char RespostaQuestao(int questao)
        {
            if (questao < 1 || questao > respostas.Length)
            {
                throw new ArgumentOutOfRangeException(" Questão inválida!");
            }
            return respostas[questao - 1];
        }

        // Retorna o número total de questões no gabarito
        public int TotalQuestoes()
        {
            return respostas.Length;
        }

        // Retorna o gabarito completo
        public string ListarGabarito()
        {
            string gabaritoString = " Gabarito:\r\n";
            for (int i = 0; i < respostas.Length; i++)
            {
                gabaritoString += $" Questão {i + 1}: {respostas[i]}\n";
            }
            return gabaritoString;
        }
    }
}