<!--
❗ ➤ References used in this Repository:
🔗 • https://github.com/piyushsuthar/github-readme-quotes
🔗 • https://github.com/kyechan99/capsule-render
🔗 • https://github.com/DenverCoder1/custom-icon-badges
🔗 • https://profilepicturemaker.com
🔗 • https://shields.io
🔗 • https://emoji.gg
🔗 • https://getemoji.com
-->

<div align="left">
  <img src="https://img.shields.io/github/license/juletopi/POO_Programacao_Orientada_a_Objetos" alt="Licence-badge">
</div>

<br>

<!-- PRESENTATION -->

<div align="center">
    <a href="https://github.com/juletopi/Algoritmos_e_Logica_de_Programacao/blob/main/Assets/Images/Algorithms-pic.png">
        <img src="https://github.com/juletopi/POO_Programacao_Orientada_a_Objetos/assets/76459155/3bc0342c-d326-42c2-a8e3-502805e413d9" alt="POO-pic" width="130px" title="Repositório de Programação Orientada a Objetos">
    </a>
    <h2 align="center">Programação Orientada a Objetos 🧩</h2>
</div>

<div align="center">
 
  • Este é um repositório com o conteúdo das aulas de Programação Orientada a Objetos, \
  ministradas pelo professor [**Elias de Abreu**](https://www.linkedin.com/in/elias-de-abreu-domingos-da-silva-843748262/), utilizando o **Visual Studio** e \
  **MySQL** como ferramentas de aprendizado.
 
</div>

<div align="center">
  <a href="https://visualstudio.microsoft.com/">
    <img src="https://img.shields.io/badge/Made%20with%20IDE:-Visual%20Studio%20-gray.svg?colorA=655BE1&amp;colorB=4F44D6&amp;style=for-the-badge" alt="VisualStudioIDE-badge" style="max-width: 100%;">
  </a>
  <a href="https://dotnet.microsoft.com/en-us/languages/csharp">
    <img src="https://img.shields.io/badge/Made%20with%20IDE:-MySQL%20-gray.svg?colorA=28679f&amp;colorB=e4a423&amp;style=for-the-badge" alt="MySQLIDE-badge" style="max-width: 100%;">
  </a>
</div>

<!-- ABOUT TEACHER -->

## 👨‍🏫 Professor:

<a href="">
  <img align="left" height="135px" width="135px" alt="EliasAbreu-pic" title="Professor Elias de Abreu" src="https://github.com/juletopi/POO_Programacao_Orientada_a_Objetos/assets/76459155/9f7a51ff-83bf-4d2c-8686-9e2abe230977">
</a>

  **Elias de Abreu Domingos da Silva - Entusiasta em TI | Professor de Curso Técnico e Superior** \
  [**IFRO Campus Ji-Paraná**](https://portal.ifro.edu.br/ji-parana) • <i>Atuando desde Dezembro de 2017</i> \
  Linguagens & Tecnologias: `Visual Studio` • `MySQL` • `C#` • `SQL` • `E outros...` \
  Contato: **[Elias de Abreu (LinkedIn)](https://www.linkedin.com/in/elias-de-abreu-domingos-da-silva-843748262/)**

</div>

<br>

<!-- ABOUT TOPIC -->

## Programação Orientada a Objetos (P.O.O)

### O que é isso?

A Programação Orientada a Objetos (POO) é uma maneira de escrever código pensando em objetos interconectados, cada um com suas próprias características e habilidades. Isso nos ajuda a organizar o código de forma lógica, dividindo-o em classes e objetos. 

Os principais conceitos são:
- **Classe**: É um modelo para criar objetos, especificando os atributos e métodos que os objetos terão.
- **Objeto**: É uma instância de uma classe que representa uma entidade específica com dados e funcionalidades definidos pela classe.
- **Métodos**: São as ações que um objeto pode realizar, definidos dentro das classes. Eles podem receber parâmetros, realizar operações e retornar valores, permitindo que os objetos interajam entre si e com o ambiente.
- **Herança:** Permite que uma classe herde características de outra, evitando repetição de código.
- **Encapsulamento:** Esconde partes do código e permite acesso apenas por métodos específicos.
- **Polimorfismo:** Diferentes objetos podem ser tratados de maneira uniforme, mesmo sendo de classes diferentes.
- **Abstração**: É o processo de identificar as características essenciais de um objeto, ignorando os detalhes irrelevantes. Isso é feito definindo classes que encapsulam o comportamento e estado das entidades do mundo real.

POO torna o código mais organizado, fácil de entender e reutilizável, como um conjunto de Lego para construir programas.

<div align="left">
  <h6><a href="#programação-orientada-a-objetos-"> Voltar para o início ↺</a></h6>
</div>

## 📚 Conceitos Aprendidos:

### 1. Classes, Objetos e Métodos

> [!NOTE]\
> *Retirado da aula de "[Software_de_Gerenciamento](---)"*

<div align="left">

  Nesta aula foram aprendidos:
  - Conceitos básicos para a criação de Classes
  - Conceitos básicos para a criação de Objetos
  - Criação de Métodos na mesma instância das Classes
 
</div>
  
```c#
public class Funcionario // <-- Criação da Classe "Funcionário"
{
    public string nome; 
    public string cpf;
    public string email;
    public string senhaAcesso;
    public DateTime dataNascimento;
    public string sexo;

    public int CalcularIdade() // <-- Criação dum Método que calcula a idade do duncionário
    {
        DateTime dataAtual = DateTime.Today;
        int idade = dataAtual.Year - dataNascimento.Year;

        if (dataAtual < dataNascimento.AddYears(idade))
        {
            idade--;
        }

        return idade;
    }
}

static void Main(string[] args) // <-- Main program
{
    // SOFTWARE DE GERENCIAMENTO - APRENDENDO A FAZER CLASSES E ATRIBUTOS

    // A empresa "Plugar Tecnologia" deseja desenvolver um software para gerenciar os serviços oferecidos aos clientes.
    // Para isso, é necessário cadastrar os clientes com os seguintes dados: Nome, CPF, Data de Nascimento e Sexo.
    // Também é necessário cadastrar os funcionários com: Nome, CPF, E-mail, Senha de Acesso, Data de Nascimento e Sexo.
    // Cada serviço serviço possui: Um código, Nome, Valor Estimado, Garantias e o Tempo Estimado para a realização.

    // Um caixa tem um dos serviços oferecidos aos clientes em forma de vendas, cada venda tem uma Data, Horário,
    // Valor Total, Cliente, os Serviços Oferecidos e um Caixa de ata de abertura, uma Data de Fechamento,
    // um Funcionário Responsável, Valor de Abertura, Status (Aberto ou Fechado) e o Saldo Final.

    // -------------------------------------------------------------------------------

    Funcionario f1 = new Funcionario(); // <-- Criando um novo objeto para a classe e atribuindo valores
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
```
<div align="left">
  <h6><a href="#programação-orientada-a-objetos-"> Voltar para o início ↺</a></h6>
  
<br>

<!-- AUTHOR -->

## 👤 Autor

<table>
  <tr>
    <td valign="top" width="33%">
      <div align="center">  
        <a href="https://github.com/juletopi">
          <img src="https://user-images.githubusercontent.com/76459155/220271784-9f930c36-c370-4518-9b56-604627c6e2b5.png" width="120px;" alt="JuletopiAvatar-pic" title="Autor: Juletopi" />
          <br>
          <sub><b>Júlio Cézar | Juletopi</b></sub>
        </a>
      </div>
    </td>
    <td valign="left" width="100%">
      <div align="left">
        <ul>
          <li>
            <sub><img align="center" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/linkedin/linkedin-original.svg" height="15" alt="LinkedIn-icon"> LinkedIn - <a href="https://www.linkedin.com/in/julio-cezar-pereira-camargo/">Júlio Cézar P. Camargo</a></sub>
          </li>
          <li>
            <sub><img align="center" src="https://pngimg.com/uploads/email/email_PNG100738.png" height="15" alt="Facebook-icon"> Email - <a href="mailto:juliocezarpvh@hotmail.com">juliocezarpvh@hotmail.com</a></sub>
          </li>
          <li>
            <sub><img align="center" src="https://cdn3.emoji.gg/emojis/6158-whatsapp.png" height="15" alt="WhatsApp-icon"> Whatsapp - <a href="http://api.whatsapp.com/send?phone=5569993606894">+55 (69) 9 9360-6894</a></sub>
          </li>
          <li>
            <sub><img align="center" src="https://cdn3.emoji.gg/emojis/6333-instagram.png" height="15" alt="Instagram-icon"> Instagram - <a href="https://www.instagram.com/juletopi/">@juletopi</a></sub>
          </li>
        </ul>
      </div>
    </td>
  </tr>
</table>

<div align="left">
  <h6><a href="#programação-orientada-a-objetos-"> Voltar para o início ↺</a></h6>
</div>

<br>

<!-- THANK YOU, GOODBYE -->

----

<div align="center">
  <a href="https://git.io/typing-svg">
    <img src="https://readme-typing-svg.demolab.com?font=Sue+Ellen+Francisco&size=40&duration=1&pause=99999&color=8354d2&center=true&vCenter=true&repeat=false&width=620&height=60&lines=Obrigado+por+visitar%2C+e+até+a+próxima!" alt="TypingGoodbye-SVG" title="Boas venturas e volte sempre que precisar! ;)"/>
  </a>
</div>

<div align="center">
  Feito com 💜 por <a href="https://github.com/juletopi"> Juletopi</a>.
</div>
