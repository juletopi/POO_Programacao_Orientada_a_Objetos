using System;

namespace Exercicio_05.Classes
{
    public class Utilitario : Veiculo // <-- Classe Derivada "filho" Utilitario
    {
        public Utilitario() : base(3.50) { }

        // Sobrescreve o método "CalcularPedagio" para os veículos utilitários
        public override void CalcularPedagio()
        {
            PrecoPedagio = QtdEixos * 3.50; // <-- Valor de R$3,50 por eixo
            PrecoPedagio += PrecoPedagio * 0.02; // <-- // Adiciona 2% de taxa de manutenção
        }
    }
}