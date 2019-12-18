using System;
using System.Collections.Generic;
using System.Linq;

namespace T7Towns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Задача 372. Елементите на масив са имена на населени места. Да се съставят методи за:" +
                " Подусловие а) въвеждане на елементите на масива и к) сортиране в азбучен ред.");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Въведете до 10 града в България: ");
            Console.WriteLine("Ако искате да спрете да въвеждете натиснете 0.");
            string[] settlements = new string[10]; //Прецених, че 10 града биха били достатъчни
            for (int i = 0; i < settlements.Length; i++)
            {
                string stop = "0"; //Създадох стринг с 0, за да го използвам за стоп при въвеждане.
                settlements[i] = Console.ReadLine();
                if (settlements[i] == stop)
                {
                    settlements[i] = null;
                    break;
                }
                else
                {
                    settlements[i] = settlements[i];
                }
            }
            List<string> cities = new List<string>(settlements);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Градовете, които написахте са: ");
            PrintTowns(cities);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Градовете подредени в азбучен ред: ");
            SortTowns(cities);
            Console.WriteLine();

        }

        private static void SortTowns(List<string> towns)
        {
            towns.Sort();
            foreach (string town in towns)
            {
                Console.WriteLine(town);
            }
        }

        private static void PrintTowns(List<string> towns)
        {
            
           
            foreach (string town in towns)
            {
                Console.Write(town + " ");
            }
            
        }


    }
}
