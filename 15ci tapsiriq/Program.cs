using System;

namespace _15ci_tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
        
        l1:
            Console.Write("6 Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("5 Reqemli eded daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("5 Reqemli eded daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("4 Reqemli eded daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("4 Reqemli eded daxil edin: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("3 Reqemli eded daxil edin: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("3 Reqemli eded daxil edin: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (a >= 100000 && a <= 999999)
            {
                if (b >= 10000 && b <= 99999)
                {
                    if (c >= 10000 && c <= 99999)
                    {
                        if (d >= 1000 && d <= 9999)
                        {
                            if (e >= 1000 && d <= 9999)
                            {
                                if (x >= 100 && x <= 999)
                                {
                                    if (y >= 100 && y <= 999)
                                    {
                                        Console.WriteLine(a);
                                        Console.WriteLine(b);
                                        Console.WriteLine(c);
                                        Console.WriteLine(d);
                                        Console.WriteLine(e);
                                        Console.WriteLine(x);
                                        Console.WriteLine(y);
                                    }
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Duzgun Daxil edin!!!");
                goto l1;
            }
            Console.Clear();
            int num1 = x + y; //3 reqemli topla
            int num2 = e * d; //4 reqemli hasil
            int num3 = b + c; //5 reqemli cem
            int num4 = ((x * y) * 10) + 1; //3 reqemli hasil +1
            int num5 = (x + y + e + d);    //3 ve 4 cem

            int sum1 = num1 + num2;
            int sum2 = (sum1 * 10) + 7;
            int sum3 = sum2 + num3;
            int sum4 = sum3 - num4;
            int sum5 = sum4 + a;
            int sum6 = sum5 - num5;
            double sum7 = (((sum6 * 0.18) * 0.03) * 0.01);
            double sum8 = sum7 + num3;
            Console.WriteLine("Yekun Cavab(Axir kiii): "+sum8);











        }
    }
}
