using System;

namespace T2ArithmeticExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Задача 4. Да се напишат като аритметични изрази на езика С# следните алгебрични изрази: Подусловие д)");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Enter a value of x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value of y: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value of z: ");
            double z = double.Parse(Console.ReadLine());

            double sumOfxAndy = x + y; //Отделям си х + у
            double subOfyAndx = y - x; //Отделям си У-х
            double denominator = x + (z / subOfyAndx); //Отделям си делителя
            double expressionInBrackets = z + (z / denominator); //Отделям си израза в скобите
            double arithmeticExpression = sumOfxAndy / expressionInBrackets;

            Console.WriteLine($"The solution of the expression is: {arithmeticExpression} ");
        }
    }
}
