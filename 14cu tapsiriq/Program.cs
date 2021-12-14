using System;

namespace _14cu_tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("6 Reqemli eded daxil edin: ");
            long a = Convert.ToInt32(Console.ReadLine());
            Console.Write("6 Reqemli eded daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("6 Reqemli eded daxil edin: ");
            long c = Convert.ToInt32(Console.ReadLine());
            Console.Write("6 Reqemli eded daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("6 Reqemli eded daxil edin: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("6 Reqemli eded daxil edin: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (a >= 100000 && a <= 999999)
            {
                if (b >= 100000 && b <= 999999)
                {
                    if (c >= 100000 && c <= 999999)
                    {
                        if (d >= 100000 && d <= 999999)
                        {
                            if (e >= 100000 && d <= 999999)
                            {
                                if (x >= 100000 && x <= 999999)
                                {
                                    Console.WriteLine(a);
                                    Console.WriteLine(b);
                                    Console.WriteLine(c);
                                    Console.WriteLine(d);
                                    Console.WriteLine(e);
                                    Console.WriteLine(x);
                                }
                            }
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
            long num1 = a + b + c + d + e + x;
            long num2 = (a * 1000000) + c;
            double num3 = (num1 - num2)*0.1;
            double num4 = (num3 + e + x)*0.11;
            Console.WriteLine("Yekun Cavab: "+num4);




        }
    }
}
