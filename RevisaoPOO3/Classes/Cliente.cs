using System;

namespace RevisaoPOO3.Classes
{
    public class Cliente // <-- Classe Base "pai" Cliente
    {
        // Propriedades comuns a todos os clientes
        public string ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        // Método virtual que pode ser sobrescrito nas classes derivadas para cadastrar as informações do cliente
        public virtual void Cadastrar()
        {
            // Este método será implementado nas classes derivadas...
        }

        // Método virtual que pode ser sobrescrito para exibir informações do cliente
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"ID: {ID} - Nome: {Nome} - Email: {Email} - Telefone: {Telefone}");
        }
    }
}