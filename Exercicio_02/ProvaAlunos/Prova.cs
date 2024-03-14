using System;
using System.Collections.Generic;

namespace ProvaAlunos
{
    public class Prova
    {
        public Gabarito gabarito;
        public List<char[]> respostasAlunos = new List<char[]>();

        // 1. Construtor
        public Prova(Gabarito gabarito)
        {
            this.gabarito = gabarito;
        }

        // 2. Insere a resposta do aluno para uma questão
        public void RespostaAluno(char[] respostas)
        {
            respostasAlunos.Add(respostas);
        }

        // 3. Retorna a quantidade de questões que o aluno acertou
        public int Acertos(char[] respostas)
        {
            int acertos = 0;
            for (int i = 0; i < gabarito.TotalQuestoes(); i++)
            {
                if (respostas[i] == gabarito.RespostaQuestao(i + 1))
                {
                    acertos++;
                }
            }
            return acertos;
        }

        // 4. Retorna a nota do aluno
        public double Nota(char[] respostas)
        {
            return (double)Acertos(respostas) / gabarito.TotalQuestoes() * 10;
        }

        // 5. Retorna a nota do aluno que acertou mais questões
        public double Maior()
        {
            double maiorNota = 0;
            foreach (var respostas in respostasAlunos)
            {
                double nota = Nota(respostas);
                if (nota > maiorNota)
                {
                    maiorNota = nota;
                }
            }
            return maiorNota;
        }

        // Retorna a lista de alunos com suas respostas, acertos e notas
        public List<string> ListarAlunos()
        {
            List<string> alunos = new List<string>();
            for (int i = 0; i < respostasAlunos.Count; i++)
            {
                char[] respostas = respostasAlunos[i];
                int acertos = Acertos(respostas);
                double nota = Nota(respostas);
                alunos.Add($" Aluno {i + 1}: Acertos = {acertos}, Nota = {nota}");
            }
            return alunos;
        }
    }
}