using System;

namespace _10cu_tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("4 Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("4 Reqemli eded daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("4 Reqemli eded daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a >= 1000 && a <= 9999)
            {
                if (b >= 1000 && b <= 9999)
                {
                    if (c >= 1000 && c <= 9999)
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
            double num1 = a * 0.01;
            double num2 = b * 0.02;
            double num3 = c * 0.03;
            double num4 = (num1 - num2 - num3)+(c*0.07);
            Console.WriteLine("Yekun cavab: "+num4);



        }
    }
}
