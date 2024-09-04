namespace Banco_de_Dados__POO_.Classes
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        // Método para representar o usuário como uma string
        public override string ToString()
        {
            return $"ID: {ID}, Nome: {Nome}, E-mail: {Email},";
        }
    }
}