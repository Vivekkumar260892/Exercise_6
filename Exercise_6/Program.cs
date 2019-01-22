using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input any Number");
            String Input = Console.ReadLine();
            int a = Convert.ToInt32(Input);
            int i, j, k;
            for (i = a; i >= 1; i--)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (k = a; k >= i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
