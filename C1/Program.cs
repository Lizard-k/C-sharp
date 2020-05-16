using System;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbe 1:");
            int l1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj liczbe 2:");
            int l2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj liczbe 3:");
            int l3 = Convert.ToInt32(Console.ReadLine());
            int min = l1;
            if (l2 < min)
                min = l2;
            if (l3 < min)
                min = l3;
            Console.WriteLine("Minimum to {0}", min);
            int max = l1;
            if (l2 > max)
                max = l2;
            if (l3 > max)
                max = l3;
            Console.WriteLine("Maximum to {0}", max);
            double średnia = (l1 + l2 + l3) / 3;
            Console.WriteLine("średnia to {0}", średnia);
            Console.ReadKey();
        }
    }
}
