using System;

namespace _12ci_tapsiriq
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
            Console.Write("6 Reqemli eded daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());
            if (a >= 100000 && a <= 999999)
            {
                if (b >= 100000 && b <= 999999)
                {
                    if (c >= 100000 && c <= 999999)
                    {
                        if (d >= 100000 && d <= 999999)
                        {
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                            Console.WriteLine(c);
                            Console.WriteLine(d);
                        }
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
            double num1 = (a * 0.1 + b * 0.1 + c * 0.1 + d * 0.1);
            double num2 = (a * 0.15 + b * 0.15 + c * 0.15 + d * 0.15);
            double num3 = num1 * num2;
            double num4 = (num3 * 0.1) * 0.11;
            Console.WriteLine("Yekun cavab: "+num4);


        }
    }
}
