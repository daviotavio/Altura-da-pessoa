using System;

namespace altura_alto_ou_baixo
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.Write("Qual a sua altura em centímetros? ");
            altura = int.Parse(Console.ReadLine()); 

            if (altura >= 180)
            {
                Console.Write("Alto");
            }
            else
            {
                Console.WriteLine("Baixo");
            }
        }

    }
}
