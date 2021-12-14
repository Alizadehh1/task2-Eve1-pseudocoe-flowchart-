using System;

namespace _8ci_tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("4 Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2 Reqemli eded daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a >= 1000 && a <= 9999)
            {
                if (b>=10 && b<=99)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Duzgun daxil edin!!");
                goto l1;
            }
            Console.Clear();
            double num1 = a * 0.04;
            double num2 = b * 0.09;
            double num3 = (num1 + num2) * 0.1;
            Console.WriteLine("Yekun Cavab: "+num3);






        }
    }
}
