using System;

namespace _5ci_tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
            l1:
            Console.Write("4 Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>=1000 && a<=9999)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("4 Reqemli deyil!!");
                goto l1;
            }
            Console.Clear();
            int num1 = 40000 + a;
            Console.WriteLine("Evveline 4 yazdiq: "+num1);
            int num2 = (num1 * 100) + 44;
            Console.WriteLine("sonuna 44 yazdiq: "+num2);
            double num3 = (num2 * 0.44);
            Console.WriteLine("44%'i: "+num3);

            
        }
    }
}
