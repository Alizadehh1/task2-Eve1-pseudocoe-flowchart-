using System;

namespace _6ci_tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("4 Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 1000 && a <= 9999)
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
            double num1 = a * 0.2;
            Console.WriteLine("Ededin 20%i: "+num1);
            double num2 = num1 * 0.1;
            Console.WriteLine("Ededin 20%nin 10%i: "+num2);
            double num3 = Math.Pow(num2, 2);
            Console.WriteLine("Ededin kvadrati: "+num3);

        }
    }
}
