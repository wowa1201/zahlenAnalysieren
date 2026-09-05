/*
#wowa1201
Aufgabe: Zahlen analysieren
Schreibe ein Programm, das den Benutzer nach 5 ganzen Zahlen fragt.

Das Programm soll anschließend:

die größte Zahl ausgeben
die kleinste Zahl ausgeben
den Durchschnitt berechnen und ausgeben
sagen, wie viele der Zahlen gerade sind

Bonus: Lass den Benutzer zuerst eingeben, wie viele Zahlen er eingeben möchte.
*/
using System;



namespace Main
{
    public class zahlenAnalysieren
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("geben Sie fünf ganze Zahlen ein:");
            Console.WriteLine("Die Zahlen dürfen nicht gleich sein");
            Console.WriteLine("Die Zahlen dürfen nur von 1 - 10 eingegeben werden");

            while (true)
            {
            
                string zahlEins = Console.ReadLine();
                string zahlZwei = Console.ReadLine();
                string zahlDrei = Console.ReadLine();
                string zahlVier = Console.ReadLine();
                string zahlFuenf = Console.ReadLine();
                int zahl1 = int.Parse(zahlEins);
                int zahl2 = int.Parse(zahlZwei);
                int zahl3 = int.Parse(zahlDrei);
                int zahl4 = int.Parse(zahlVier);
                int zahl5 = int.Parse(zahlFuenf);
                if (zahl1 == zahl2 == zahl3 == zahl4 == zahl5)
                {
                    Console.WriteLine("Die Zahlen dürfen jeweil nur ein Mal vorkommen");
                }
                else if(zahl1 < 0 || >100 ||
                        zahl2 < 0 || > 100 ||
                        zahl3 < 0 || > 100 ||
                        zahl4 < 0 || > 100 ||
                        zahl5 < 0 || > 100)
                {
                    Console.WriteLine("Die Zahl darf nicht größer als 100 und nicht kleiner 0 sein");
                }
           
                
                
            }
        }
    }
}