using System;

namespace _9cu_tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
            l1:
            Console.Write("6 Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("6 Reqemli eded daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("6 Reqemli eded daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a >= 100000 && a <= 999999)
            {
                if (b >= 100000 && b <= 999999)
                {
                    if (c >= 100000 && c <= 999999)
                    {
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                    }
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Duzgun daxil edin!!");
                goto l1;
            }
            Console.Clear();
            double num1 = (a * 0.1 + b * 0.1 + c * 0.1);
            double num2 = (num1 * 0.1);
            Console.WriteLine("Yekun cavab: "+num2);



        }
    }
}
