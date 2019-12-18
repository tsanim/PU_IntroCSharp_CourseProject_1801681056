using System;
using System.Collections.Generic;

namespace T5TaskWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Задача 374 " +
                "Да се въведат от клавиатурата произволно число к и произволен брой ненулеви числа (за край на въвеждането да служи числото 0" +
                "Да се отпечата сумата на тези от тях, които са различни от нула." +
                "2. Да се въведат от клавиатурата 10 числа. Да се намери и отпечата на екрана произведението на тези от тях, които са в интервала [2, 12]." +
                "3. Да се създаде метод Sum(k) , който генерира к на брой случайни цели числа и като резултат връща сумата на тези от тях, които са четни." +
                "В главния метод да се въведат 3 цели положителни числа а, b и c. Да се намери и отпечата: Sum(a*b)+Sum(c).");
            Console.WriteLine("----------------------------------------------------------------------------------");
           
            Console.WriteLine("Enter the numbers which we will sum: ");
            Console.WriteLine("If you want to stop , type in 0.");
            int[] nums = new int[byte.MaxValue]; //Сложил съм граница от byte.MaxValue, защото мисля, че е достатъчно дълга за дължина на масив, който ще бъде въвеждан от потребителя.

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Num[" + i + "]= ");
                nums[i] = int.Parse(Console.ReadLine());
                if (nums[i] == 0)
                {
                    nums[i] = 0;
                    break;
                }
                else
                {
                    nums[i] = nums[i];
                }
            }

            Console.WriteLine("The sum of the entered numbers is: " + ManipulationNumbers.SumNNumbers(nums));

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Enter 10 numbers: ");

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Num[" + i + "]= ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The multiplication of the numbers you entered which are in an interval of 2 to 12 is: " + ManipulationNumbers.MultiplicationOfTenNums(numbers));
            

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Sum(k) generates k random numbers and calculate the sum of the even numbers.");
            Console.WriteLine("Enter a, b and c to calculate the sum of Sum(a*b)+Sum(c)");
           
            Console.WriteLine("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            int c = int.Parse(Console.ReadLine());
            int multipl = a * b; //Отделям си умножението от а и б, за да го включа в метода

            int sum = ManipulationNumbers.SumOfKNumbers(multipl) + ManipulationNumbers.SumOfKNumbers(c);

            Console.WriteLine($"The sum of Sum(a*b)+Sum(c) is " + sum);

            Console.ReadKey();
        }
    }
}
