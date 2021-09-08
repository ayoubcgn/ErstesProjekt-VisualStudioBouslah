using System;

// So schreibst du einen Kommentar
/* Alle Zeichen die in dieser Kommtar-Variante stehen werden als Kommentar Interpretiert */

namespace Tutorial
{
    class Tutorial1
    {
        /* Mit 'static' werden Methoden bezeichnet die beim Aufruf kein spezifisches Objekt voraussetzen, 
        und 'void' beschreibt eine Methode ohne Rückgabewert. 
        'Main' ist eine Methode von herrausragender Bedeutung. Wenn Laufzeitumgebung der EXE-Datei startet, wird zuerst 'Main' ausgeführt*/


        static void Main()
        {
            //----------------------------------------------Elementare Syntax-------------------------------------------------------------------------------------

            Console.Write("Hallo...");                      //Anweisungen enden immer mit einem Semikolon // Methode erzeugt eine Ausgabe
                                                            //Konsolen-Cursor am Ende der Zeile 

            Console.                                        //Anweisungen können in verschiedene Zeilen aufgeteilt werden //
                WriteLine                                   //Diese Methode erzeugt eine Ausgabe in der Konsole // Cursor in der nächste Zeile
                /*Kommentar*/("C# macht spaß");             //Kommentare können in mitten einer Anweisung stehen


            Console.ReadLine();                             //Reagiert nur auf 'Enter'

            Console.ReadKey(); ; ; ; ; ;                    //Reagiert auf jede Taste //Mehrere Semikolons füren nicht zu einem Fehler            



            //----------------------------------------------Datendeklaration-------------------------------------------------------------------------------------

            int value;                                      //Deklaration durch Datentyp + Bezeichner
                                                            //(Der Bezeichner repräsentiert eine Speicheradresse im Arbeitsspeicher)

            /* Variablenbezeichner
            ->Ein Bezeichner setzt sich aus alphanumerischen Zeichen und dem Unterstrich zusammen.
              Leerzeichen und andere Sonderzeichen wie beispielsweise #, § und $ sind nicht zugelassen.           
            ->Ein Bezeichner muss mit einem Buchstaben oder dem Unterstrich anfangen.
            ->Ein einzelner Unterstrich als Variablenname ist nicht zugelassen.
            ->Der Bezeichner muss eindeutig sein, Er darf nicht gleichlautend mit einem Schlüsselwort, einer Methode
              , einer Klasse oder einem Objektnamen sein.
            */

            value = 1234;                                   //Zuweisung eines gültigen Wertes (Initialisierung)

            double value2 = 1000.11;                        //Deklaration und Initialisierung können in einer Anweisung erfolgen
            Console.WriteLine(value + value2);                //Werte werden in der Konsole addiert ausgegeben

            long a = 10, b = 1000000000000000000;           //Mehrere Variablen gleichen Typs deklarieren und direkt initialisieren


            //----------------------------------------------Variable durch Platzhalter-------------------------------------------------------------------------------------

            Console.WriteLine
                ("Wert von 'a' = {0}\n\nWert von 'b' = {1}", b, a);           //Konsolenausgabe der Variable durch Platzhalter { }

            Console.WriteLine("Ich kaufe {0,20} Eier", a);                    //Breite des einzusetzenden Wertes {N,M}
            Console.WriteLine("Ich kaufe {0,-20} Eier", a);                  //->N ist ein nullbasierter Zähler ->M gibt die Breite der Ausgabe
            /*Die Ausgabe hat eine Gesamtbreite von 10 Zeichen,
                die Zahl selbst allerdings nur zwei Ziffern. Daher wird vor ggf. nach der Zahl 8
                Leestellen eingefügt*/


            /*  Vollständige Syntax des Formatausdrucks:
                {N [,M][:Format]}
                Formatangabe    Beschreibung
                C               Zeigt die Zahl im lokalen Währungsformat.
                D               Zeigt die Zahl als dezimalen Integer an.
                E               Zeigt die Zahl im wissenschaftlichen Format
                                (Exponentialschreibweise).
                F               Zeigt die Zahl im Festpunktformat an.
                G               Eine numerische Zahl wird entweder imFestpunkt- 
                                oder im wissenschaftlichen Format angezeigt. 
                                Zur Anzeige kommt das >>kompakteste<< Format.
                N               Zeigt eine numerische Zahl einschließlich Kommaseparatoren.
                P               Zeigt die numerische Zahl als Prozentzahl an. 
                X               Die Anzeige erfolgt in Hexadezimalnotation.*/


            Console.WriteLine("value = {0:E}", value);                  //Ausgabe: value=1,234000E+003
            Console.WriteLine("value={0:E2}", value);                   //Ausgabe: value=1,23E+003

            float value3 = 0.2512F;
            Console.WriteLine("value3={0,10:G}", value3);               //Ausgabe: value3=    0,2512
            Console.WriteLine("value3={0:P4}", value3);                 //Ausgabe: value3=25,1200 %
            Console.WriteLine($"a={a},b={b}");
            Console.WriteLine("a={0},b={1}", a, b);                      //Angabe der Variablen innerhalb der geschweiften Klammern
                                                                         //Beachten Sie, dass vor der Zeichenfolge $ gesetzt wird


            //----------------------------------------------Formatierung der Ausgabe-------------------------------------------------------------------------------------

            /*  Escape-Zeichen
                werden verwendet wenn Sonderzeichen innerhalb einer Zeichenfolge
                ausgegeben werden sollen.
                Escape-Zeichen      Beschreibung
                \'                  Fügt ein Hochkomma in die Zeichenfolge ein.
                \''                 Fügt Anführungsstriche ein.
                \\                  Fügt einen Backslash in die Zeichenfolge ein.
                \a                  Löst einen Alarmton aus.
                \b                  Führt zum Löschen des vorhergehenden Zeichens.
                \f                  Löst einen Formularvorschub bei Druckern aus.
                \n                  Lost einen Zeilenvorschub aus(entspricht der 
                                    Funktionalität der 'ENTER'-Taste)
                \r                  Führt zu einem Wagenrücklauf.
                \t                  Führt auf dem Bildschirm zu einem Tabulatorsprung. 
                \u                  Fügt ein Unicode-Zeichen in die Zeichenfolge ein.
                \v                  Fügt einen vertikalen Tabulator in eine Zeichenfolge ein.
             */

            Console.WriteLine("Hallo\\nWelt");                          //Ausgabe: Hallo\nWelt // Ein zweiter Backslash erzwingt die Ausgabe
                                                                        //---------------------------------------------->>ReadLine<< und >>Read<<-------------------------------------------------------------------------------------


            string input1 = Console.ReadLine();                        //
            Console.WriteLine(input1);                                 //

            int input2 = Console.Read();                               //
            Console.WriteLine(input2);                                 //
            Console.ReadLine();                                        //

        }
    }






}
    

