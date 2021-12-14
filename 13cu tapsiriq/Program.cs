using System;

namespace _13cu_tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("5 Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("5 Reqemli eded daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("5 Reqemli eded daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("3 Reqemli eded daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("3 Reqemli eded daxil edin: ");
            int e = Convert.ToInt32(Console.ReadLine());
            if (a >= 10000 && a <= 99999)
            {
                if (b >= 10000 && b <= 99999)
                {
                    if (c >= 10000 && c <= 99999)
                    {
                        if (d >= 100 && d <= 999)
                        {
                            if (e>=100 && d<=999)
                            {
                                Console.WriteLine(a);
                                Console.WriteLine(b);
                                Console.WriteLine(c);
                                Console.WriteLine(d);
                                Console.WriteLine(e);
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
            double num1 = (a * 0.05 * b * 0.05 * c * 0.05);
            double num2 = (d * 0.03 + e * 0.03);
            double num3 = ((num1 * 0.1) + (num2 * 0.1));
            Console.WriteLine("Yekun Cavab: "+num3);


        }
    }
}
