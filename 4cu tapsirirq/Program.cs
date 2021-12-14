using System;

namespace _4cu_tapsirirq
{
    class Program
    {
        static void Main(string[] args)
        {
            l1:
            Console.Write("3 Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>=100 && a<=999)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("3 Reqemli deyil!");
                goto l1;
            }
            Console.Clear();
            int num1 = 7000 + a;
            Console.WriteLine("evveline 7 artirdiq: "+num1);
            double num2 = num1 * 0.07;
            Console.WriteLine("7%'i: "+num2);
            
        }
    }
}
