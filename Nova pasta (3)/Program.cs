using System;

namespace Nova_pasta__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento;
            int anoAtual;
            int idade;

            Console.WriteLine("Por favor,insira o ano de seu nascimento abaixo: ");
            anoNascimento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Agora, por favor insira o ano atual abaixo:");
            anoAtual = Convert.ToInt32(Console.ReadLine());
            idade = anoAtual-anoNascimento;
            Console.WriteLine("Sua idade é de " + idade +" anos, ou seja aproximadamente " + idade*52 + " semanas.");
        }
    }
}
