using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento;
            int anoAtual;
            int idade;

            idade = anoAtual-anoNascimento;

            Console.WriteLine("Por favor,insira o ano de seu nascimento abaixo: ");
            anoNascimento = Console.ReadLine();
            Console.WriteLine(" Agora, por favor insira o ano atual abaixo:");
            anoAtual = Console.ReadLine();
            Console.WriteLine("Sua idade é de " + idade +" anos, ou seja aproximadamente " + idade*52 + " semanas.");
        }
    }
}
