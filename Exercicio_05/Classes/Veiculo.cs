using System;

namespace Exercicio_05.Classes
{
    public class Veiculo // <-- Classe Base "pai" Veículo
    {
        public string Placa { get; set; }

        private int _qtdEixos; // <-- Criação de uma variável privada para a validação da exceção
        public int QtdEixos { // <-- Validação da exceção onde o valor de eixo não pode ser igual ou menor que zero
            get { return _qtdEixos; }
            set {
                if (value <= 0)
                {
                    throw new Exception("Erro: Valor de eixo não pode ser igual ou menor que zero!");
                }
                else
                {
                    _qtdEixos = value;
                }                
            }
        }
        public int Tipo {  get; set; }
        public double PrecoPedagio { get; set; }
        public double ValorFinal { get; set; }

        // Método construtor da classe "Veiculo" que inicializa o "PrecoPedagio"
        public Veiculo(double precoPedagio)
        {
            PrecoPedagio = precoPedagio;
        }

        // Método virtual que será sobrescrito nas classes derivadas
        public virtual void CalcularPedagio()
        {
            // Este método será implementado nas classes derivadas...
        }

        // Método para calcular o desconto baseado no tipo de veículo
        public void CalcularDesconto()
        {
            double desconto = 0;

            switch (Tipo)
            {
                case 1:
                    desconto = 0; // <-- Tipo 1; sem desconto
                    break;
                case 2:
                    desconto = 0.05; // <-- Tipo 2; 5% de desconto
                    break;
                case 3:
                    desconto = 1; // <-- Tipo 3; 100% de desconto
                    break;
            }
            ValorFinal = PrecoPedagio * (1 - desconto); // <-- Calculando o valor final aplicando o desconto
        }
    }
}