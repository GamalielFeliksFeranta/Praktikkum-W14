using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public static void Prima(int input)
        {
            int faktorial = 0;
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        faktorial++;
                    }
                }
                if (faktorial == 2)
                {
                    Console.Write(i + " ");
                }
                faktorial = 0;

            }
            Console.WriteLine("");
        }
        public static void nonPrima(int input)
        {
            int count = 0;
            int faktorial1 = 0;
            
                for (int i = 1; i <= input; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            faktorial1++;
                        }
                    }
                    if (faktorial1 != 2)
                    {
                        Console.Write(i + " ");
                    }
                    faktorial1 = 0;

                
            }
        }

        private const int x = 1;
        static void Main(string[] args)          
        {
            Console.Write("Masukan Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int temp = 0;
            int faktorial = 0;
            int faktorial1 = 0;
            for (int i = 1; i < input + x; i++)
            {
                temp = input % i;
                if (temp == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                nonPrima(input);
            }
            else
            {
                Prima(input);
            }

        }
    }
}
