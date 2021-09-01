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
            Console.WriteLine("Hallo...");

            
            Console.WriteLine("C# macht spaß");
            
            Console.ReadLine();
            
            Console.ReadKey();
            
            int value;

            value = 23;

            Double Value2 = 1000.11;
            Console.WriteLine(value+Value2);
            long a = 10,b = 100000000000;
            Console.WriteLine
                ("wert von ´a´ = {0} \nWert von ´b´ = {1} +{2}" ,a,b,value );




     
            

        }
    }
}
