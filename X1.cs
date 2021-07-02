using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int meses; 
            int dias;
            int horas;
            int minutos;
            
            Console.WriteLine("Qual é a sua idade?");
            idade =  Convert.ToInt32(Console.ReadLine());
            meses = idade*12;
            dias = meses*30;
            horas = dias*24;
            minutos = horas*60;
            Console.WriteLine("Então você tem "+ idade + " anos, o que é equivalente a "+ meses + " meses ou "+ dias + " dias ou "+ horas + " horas ou " + minutos + " minutos!!");
        }
    }
}
