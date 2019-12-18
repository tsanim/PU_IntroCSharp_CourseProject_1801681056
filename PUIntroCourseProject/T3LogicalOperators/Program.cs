using System;

namespace T3LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Задача 37. Ако знаковете -, ^, > означим съответно операциите" +
            " отрицание, логическо събиране (дизюнкция) и логическо умножение (конюнкция)," +
            " да се запишат  на С# следните изрази: Подусловие 4)");
            Console.WriteLine("----------------------------------------------------------------------------------");

            bool s = true;
            bool t = false;

            Console.WriteLine(!(s || t) && s || !t);
        }
    }
}
