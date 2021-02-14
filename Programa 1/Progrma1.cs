using System;

namespace Programa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int b=1;

            while (b > 0)
            {
                Console.WriteLine("Numero Mayor: a 0");
                b = int.Parse(Console.ReadLine());
                a = a + b;
                Console.Clear();
                Console.WriteLine(a);
            }
        }
    }
}
