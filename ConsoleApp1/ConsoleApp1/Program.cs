using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random rnd = new Random();  
            for (int i = 0;i< numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0,20);
                Console.Write(numbers[i]+"\t");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j<numbers.Length - 1 - i;j++)
                {
                    if (numbers[j] > numbers[j+1])
                    {
                        int k = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j + 1] = k;
                    }
                }
            }
            for(int i=0;i<numbers.Length; i++)
            {
                Console.Write(numbers[i]+"\t");
            }
            Console.WriteLine();



        }
    }
}
