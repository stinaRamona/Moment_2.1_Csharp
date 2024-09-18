
/* 
Laboration 2.1 i kursen Programmering i C#.NET, HT24 Mittuniversitetet 
Kod skriven av Stina Persson (stpe1901)
Senast uppdaterad 10/9 -24 
*/

/*
Lösningen ska vara ett program som tar emot ett inmatat datum (år-månad-dag) 
och genererar veckodagen det datument förföll på
*/

//Dagens datum hämtat och omvandlat till veckodag
using System.Globalization;
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        //sätter språket till svenska för svens output 
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sv-SE"); 
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("sv-SE"); 

        string today = System.DateTime.Now.ToString("dddd", new CultureInfo("sv-SE"));

        Console.WriteLine($"Idag är det {today}");


        //Inmatning för datum
        Console.WriteLine("Ange ett datum med följande struktur åååå, mm, dd");

        string? inputDate = Console.ReadLine(); //frågetecken efter string för den kan vara null

        //förbereder variabel 
        DateTime yourDate;

        //kontroll av inmatningen av datumet samt utläsning av veckodagen  

        //TyrParse konverterar strängen till ett datum om det är rätt inmatat och sparas i yourDate
        if (DateTime.TryParse(inputDate, out yourDate))
        {
            //Veckodagen för datumet skrivs ut 
            Console.WriteLine($"Datumet du skev var på en {yourDate.ToString("dddd", new CultureInfo("sv-SE"))}");
        }
        else
        {
            //Ifall inte strängen kan konverteras till ett datum skrivs ett felmeddelande ut och man får starta om programmet 
            Console.WriteLine("Det gick inte att konvertera det du skrev. Vänligen ange korrekta värden.");
        }
    }
}