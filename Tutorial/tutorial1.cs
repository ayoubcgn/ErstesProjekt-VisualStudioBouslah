using System;

namespace Tutorial
{
    class tutorial1
    {

        /* Mit 'static' werden Methoden bezeichnet die beim Aufruf kein spezifisches Objekt voraussetzen, 
        und 'void' beschreibt eine Methode ohne Rückgabewert. 
        'Main' ist eine Methode von herrausragender Bedeutung. Wenn Laufzeitumgebung der EXE-Datei startet, wird zuerst 'Main' ausgeführt*/
        static void Main()
        {
            Console.WriteLine("Hallo Boss");
            Console.WriteLine("Wie geht es dir heute ?");
           String Input = Console.ReadLine();
            Console.WriteLine("Die Eingabe Ist :");
            Console.WriteLine(Input);


        }
    }
}
