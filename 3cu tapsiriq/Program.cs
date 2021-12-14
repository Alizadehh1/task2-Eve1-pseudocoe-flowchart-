using System;

namespace Eve1
{
    class Program
    {
        static void Main(string[] args)
        {
            l1:
            Console.Write("5 reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>=10000 && a<=99999)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("5 reqemli deyil!");
                goto l1;
            }
            Console.Clear();
            double b = a * 0.18;
            Console.WriteLine("Ededin 18%i: " + b);
            double c = a * 0.03;
            Console.WriteLine("Ededin 3%'i: "+c);
            
            
            
        }
    }
}
