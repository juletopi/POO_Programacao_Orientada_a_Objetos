using System;

namespace Exercicio_05.Classes
{
    public class Caminhao : Veiculo // <-- Classe Derivada "filho" Caminhao
    {
        public Caminhao() : base(7.00) { }

        // Sobrescreve o método "CalcularPedagio" para os caminhões
        public override void CalcularPedagio()
        {
            PrecoPedagio = QtdEixos * 7.00; // <-- Valor de R$7,00 por eixo
            PrecoPedagio += PrecoPedagio * 0.10; // <-- // Adiciona 10% de taxa de manutenção
        }
    }
}