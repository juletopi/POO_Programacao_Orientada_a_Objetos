using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_Gerenciamento__POO_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SOFTWARE DE GERENCIAMENTO - APRENDENDO A FAZER CLASSES E ATRIBUTOS

            // A empresa "Plugar Tecnologia" deseja desenvolver um software para gerenciar os serviços oferecidos aos clientes.
            // Para isso, é necessário cadastrar os clientes com os seguintes dados: Nome, CPF, Data de Nascimento e Sexo.
            // Tamebém é necessário cadastrar os funcionários com: Nome, CPF, E-mail, Senha de Acesso, Data de Nascimento e Sexo.
            // Cada serviço serviço possui: Um código, Nome, Valor Estimado, Garantias e o Tempo Estimado para a realização.

            // Um caixa tem um dos serviços oferecidos aos clientes em forma de vendas, cada venda tem uma Data, Horário,
            // Valor Total, Cliente, os Serviços Oferecidos e um Caixa de ata de abertura, uma Data de Fechamento,
            // um Funcionário Responsável, Valor de Abertura, Status (Aberto ou Fechado) e o Saldo Final.

            // -------------------------------------------------------------------------------

            Funcionario f1 = new Funcionario();
            f1.nome = "Bernado";
            f1.cpf = "011.900.605-12";
            f1.email = "bernadin1101@gmail.com";
            f1.senhaAcesso = "090001";
            f1.dataNascimento = new DateTime(1998, 11, 01);
            f1.sexo = "M";
            int idade = f1.CalcularIdade();

            Console.Write("\r\n ┌────────────────────────────────────────┐");
            Console.Write("\r\n │ Calculando a idade dos funcionários... │");
            Console.Write("\r\n └────────────────────────────────────────┘\r\n");

            Console.WriteLine($" A idade do(a) funcionário(a) {f1.nome} é {idade} anos.");

            Funcionario f2 = new Funcionario();
            f2.nome = "Túlio";
            f2.cpf = "073.743.623-24";
            f2.email = "tuliomurilo03@gamil.com";
            f2.senhaAcesso = "090002";
            f2.dataNascimento = new DateTime(2003, 01, 17);
            f2.sexo = "M";
            idade = f2.CalcularIdade();
            Console.WriteLine($" A idade do(a) funcionário(a) {f2.nome} é {idade} anos.");

            Funcionario f3 = new Funcionario();
            f3.nome = "Letícia";
            f3.cpf = "061.807.612-14";
            f3.email = "kirbystar99@gmail.com";
            f3.senhaAcesso = "090003";
            f3.dataNascimento = new DateTime(2000, 01, 30);
            f3.sexo = "F";
            idade = f3.CalcularIdade();
            Console.WriteLine($" A idade do(a) funcionário(a) {f3.nome} é {idade} anos.");

            Console.ReadKey();
        }
    }
}