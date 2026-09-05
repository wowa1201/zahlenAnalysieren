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

            Console.WriteLine($"Ihre Eingaben: {zahl1}, {zahl2}, {zahl3}, {zahl4}, {zahl5}");

        }
    }
}