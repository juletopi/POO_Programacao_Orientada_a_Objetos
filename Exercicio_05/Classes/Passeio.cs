using System;

namespace Exercicio_05.Classes
{
    public class Passeio : Veiculo // <-- Classe Derivada "filho" Passeio
    {
        public Passeio() : base(3.00) { }

        // Sobrescreve o método "CalcularPedagio" para os veículos de passeio
        public override void CalcularPedagio()
        {
            /*
            if(QtdEixos == 0) <-- Exemplo de função if para a validação onde o valor de eixo não pode ser igual ou menor que zero
            {
                throw new Exception("Erro: Valor de eixo não pode ser igual ou menor que zero!");
            }
            */
            PrecoPedagio = QtdEixos * 3.00; // <-- Valor de R$3,00 por eixo
        }
    }
}