using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 1, auxiliar;
            Console.WriteLine("------------------------------");
            Console.WriteLine("----Sequência Fibonacci----");
            Console.WriteLine("------------------------------");
            Console.Write("Digite um número: ");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t == t)
            {
                Console.WriteLine("Série de Fibonacci:");
                for(int i = 0 ; i <=t ; i++)
                {
                    auxiliar = x + y;
                    x = y;
                    y = auxiliar;
                    Console.WriteLine(auxiliar);
                }
            }
            else{
                Console.WriteLine("Digite um número válido.");
            }
        }
    }
}
