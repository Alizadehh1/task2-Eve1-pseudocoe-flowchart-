using System;

namespace _7ci_tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("1-ci 5 Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2-ci 5 Reqemli eded daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a >= 10000 && a <= 99999)
            {
                if (b>=10000 && b<=99999)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine("5 Reqemli deyil!!");
                goto l1;
            }
            Console.Clear();
            int num1 = a + b;
            Console.WriteLine("Cemler: "+num1);
            int num2 = (num1 + 500000) * 10 + 5;
            Console.WriteLine("evveline ve sonuna 5 elave etdik: "+num2);
        }
    }
}
