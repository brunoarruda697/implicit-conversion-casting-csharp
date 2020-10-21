using System;

namespace ImplicitConversionAndCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            float b;
            int c;

            a = 5.1;
            b = (float)a;
            
            // *double tem um tamanho maior que o float em bytes, por isso caso queira fazer essa conversão
            // precisa fazer a conversão implicita com o casting -> (float)
            Console.WriteLine(b);

            c = (int)a;
            Console.WriteLine(c);

            int x = 5;
            int y = 2;
            double result = x / y;
            Console.WriteLine(result);
            result = (double)x / y;
            Console.WriteLine(result);
        }
    }
}
