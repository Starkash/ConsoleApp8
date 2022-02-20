using System;
namespace Delta
{
    class Star
    {
        static void Main(string[] args) 
        {
            int i;
            Console.WriteLine("Star printing");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i + 1; j++)

                    Console.Write("*");
            }
                Console.ReadLine();



        }
    }
}