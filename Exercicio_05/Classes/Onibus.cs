using System;

namespace Exercicio_05.Classes
{
    public class Onibus : Veiculo // <-- Classe Derivada "filho" Onibus
    {
        public Onibus() : base(5.00) { }

        // Sobrescreve o método "CalcularPedagio" para os ônibus
        public override void CalcularPedagio()
        {
            PrecoPedagio = QtdEixos * 5.00; // <-- Valor de R$5,00 por eixo
            PrecoPedagio += PrecoPedagio * 0.05; // <-- // Adiciona 5% de taxa de manutenção
        }
    }
}