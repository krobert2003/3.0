using System;

namespace Githubos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy számot");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("Nagyobb az első szám");
            }
            else
            {
                Console.WriteLine("Nagyobb a második szám");
            }
            Console.ReadKey();
        }
    }
}
