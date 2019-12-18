using System;
using System.Collections.Generic;
using System.Text;

namespace T5TaskWithNumbers
{
    class ManipulationNumbers
    {
        /// <summary>
        /// Сложил съм променлива шорт, за да не дава много големи рандъм числа.
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int SumOfKNumbers(int k)
        {
            int[] arr = new int[k];
            Random r = new Random();
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)

            {
                int rand = r.Next(short.MinValue, short.MaxValue);
                arr[i] = rand;

                if (rand % 2 == 0)
                {
                    sum += rand;
                }

            }
            return sum;
        }

        /// <summary>
        /// Направих метод за умножението на 10-те числа, за да ми стане по-добре структурирана програма.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static long MultiplicationOfTenNums(int[] numbers) 
        {
            List<int> numbersInRange = new List<int>(numbers);
            long multipl = 1;

            foreach (int num in numbers)
            {

                if (num > 2 && num < 12)
                {
                    numbersInRange.Add(num);
                    multipl *= num;
                }
                else
                {
                    Console.WriteLine("There is no number in this interval.");
                }

            }
            return multipl;
        }
        /// <summary>
        /// SumNNumbers
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SumNNumbers(int[] nums)
        {
            int sum = 0;

            foreach (int num in nums)
            {
                if (num != 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
