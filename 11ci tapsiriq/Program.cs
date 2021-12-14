using System;

namespace _11ci_tapsiriq
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
            Console.Write("5 Reqemli eded daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());
            if (a >= 10000 && a <= 99999)
            {
                if (b >= 10000 && b <= 99999)
                {
                    if (c >= 10000 && c <= 99999)
                    {
                        if (d>=10000 && d<=99999)
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
            int num1 = a + c;
            int num2 = b + d;
            double num3 = (num1 * num2)-c*0.03;
            Console.WriteLine("Yekun cavab: "+num3);



        }
    }
}
