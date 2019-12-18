using System;

namespace T4Numbers1to100InSpecificWay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Задача 211. Да се изведат числата от 1 до 100 по следния начин: Подусловие д)" +
                " 100, 1, 99, 98, 3, 4, 97, .... , 52, 49, 50, 51. ");
            Console.WriteLine("----------------------------------------------------------------------------------");

            for (int i = 1, j = 100; i <= 50; i += 2, j -= 2) 
            {
                Console.Write(j + ", " + i + ", " + (i + 1) + ", " + (j - 1) + ", ");
            }

            Console.WriteLine();
        }
    }
}
