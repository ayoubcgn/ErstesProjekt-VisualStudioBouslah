using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {


            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Konsolen-Rechner in C#\r");
            
            Console.WriteLine("------------------------");
            
            Console.WriteLine("Tippen sie eine zahl ein und drücken Sie Enter");

            string eingabe1;
            eingabe1 = Console.ReadLine();
            Console.WriteLine("Tippen sie noch eine zahl ein und drücken Sie Enter");
            string eingabe2;
            eingabe2 = Console.ReadLine();
            Console.WriteLine("Wählen sie einer der folgenden Optionen aus:");

            Console.WriteLine("\ta- Addition");
            Console.WriteLine("\ts- Subtraktion");
            Console.WriteLine("\tm- Multiplikation");
            Console.WriteLine("\td- Dividieren");
            Console.WriteLine("Deine Option?");


            Console.Write("Drücken Sie eine Taste um den Rechner zu Schließen");
            Console.ReadKey();








        }

    }
}
