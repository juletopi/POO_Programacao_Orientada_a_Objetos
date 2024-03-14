using System;

namespace EmbarqueVoos
{
    public class Voo // <-- Classe que representa um "voo"
    {
        public int numeroVoo;
        public DateTime data;
        public int capacidade;
        public bool[] ocupacao;

        // 1. Construtor
        public Voo(int numeroVoo, DateTime data, int capacidade)
        {
            this.numeroVoo = numeroVoo;
            this.data = data;
            this.capacidade = capacidade;
            this.ocupacao = new bool[capacidade];
        }

        // 2. Retorna o número da próxima cadeira livre
        public int ProximoLivre()
        {
            for (int i = 0; i < ocupacao.Length; i++)
            {
                if (!ocupacao[i])
                {
                    return i + 1;
                }
            }
            return -1; // <-- Todas as cadeiras ocupadas
        }

        // 3. Verifica se a cadeira está ocupada
        public bool Verifica(int cadeira)
        {
            if (cadeira <= 0 || cadeira > ocupacao.Length)
            {
                throw new ArgumentOutOfRangeException("Cadeira inválida!");
            }
            return ocupacao[cadeira - 1];
        }

        // 4. Ocupa uma cadeira
        public bool Ocupa(int cadeira)
        {
            if (cadeira <= 0 || cadeira > ocupacao.Length)
            {
                throw new ArgumentOutOfRangeException("Cadeira inválida!");
            }
            if (!ocupacao[cadeira - 1])
            {
                ocupacao[cadeira - 1] = true;
                return true;
            }
            return false;
        }


        // 5. Retorna o número de cadeiras vagas
        public int Vagas()
        {
            int vagas = 0;
            foreach (bool ocupada in ocupacao)
            {
                if (!ocupada)
                {
                    vagas++;
                }
            }
            return vagas;
        }

        // 6. Retorna o número do voo
        public int GetVoo()
        {
            return numeroVoo;
        }

        // 7. Retorna a data do voo
        public DateTime GetData()
        {
            return data;
        }
    }
}