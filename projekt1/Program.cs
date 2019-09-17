using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1
{
    class Program
    {
        private static int dzialania;

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbe");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe");
            var input2 = Convert.ToInt32(Console.ReadLine());
            var operation = Console.ReadKey();

           
            switch (operation.Key)
            {
                case ConsoleKey.Add:
                    var doda = new DOD();
                    doda.dod(input1, input2);
                    Console.WriteLine(doda.dod(input1, input2));
                    break;
                case ConsoleKey.Multiply:
                    var mnoz = new MN();
                    mnoz.MNO(input1, input2);
                    Console.WriteLine(mnoz.MNO(input1, input2));
                    break;
                case ConsoleKey.Subtract:
                    var odej = new ODE();
                    odej.ode(input1, input2);
                    Console.WriteLine(odej.ode(input1, input2));
                    break;
                case ConsoleKey.Divide:
                    var dziel = new DZI();
                    dziel.dzi(input1, input2);
                    Console.Clear();
                    Console.WriteLine("Wynik to ");
                    Console.WriteLine(dziel.dzi(input1, input2));
                    break;
                default:
                    break;
            }
            var next = Console.ReadKey();
            startAgain = next.Key == ConsoleKey.Enter;




            Console.ReadLine();

        }
    }
}
