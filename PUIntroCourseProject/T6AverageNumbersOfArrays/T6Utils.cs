using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T6AverageNumbersOfArrays
{
    class T6Utils
    {
        public static double GetAverageNumber(int[] numbers)
        {

            List<int> numbersInRange = new List<int>(numbers); //Правя си List от масива, за да мога да включа числата от интервала.
            double averageNum = 0;
            foreach (int num in numbers)
            {

                if (num > -100 && num < 100)
                {
                    numbersInRange.Add(num);
                }

            }
            averageNum = numbersInRange.Sum() / numbersInRange.Count();
            return averageNum;

        }

        public static void PrintArray(int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.Write(i + "  ");
            }
        }

        public static void PrintArrayItems(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Num[" + i + "]= ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
