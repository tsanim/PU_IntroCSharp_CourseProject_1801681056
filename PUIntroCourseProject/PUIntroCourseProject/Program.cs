using System;

namespace PUIntroCourseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Преобразувайте числото от десетична в двоична, осмична и шестнайсетична бройна система.");
            int number = 2056;

            Console.WriteLine("The number is: " + number);

            Console.WriteLine("The number converted to binary number system: " + Convert.ToString(number, 2));

            Console.WriteLine("The number converted to octal number system: " + Convert.ToString(number, 8));

            Console.WriteLine("The number converted to hexadecimal number system: " + Convert.ToString(number, 16));
        }
    }
}
