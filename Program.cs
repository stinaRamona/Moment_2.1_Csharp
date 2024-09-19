
/* 
Laboration 2.1 i kursen Programmering i C#.NET, HT24 Mittuniversitetet 
Kod skriven av Stina Persson (stpe1901)
Senast uppdaterad 18/9 -24 
*/

/*
Lösningen ska vara ett program som tar emot ett inmatat datum (år-månad-dag) 
och genererar veckodagen det datument förföll på
*/

using System.Globalization;

class Program
{
    static void Main()
    {
        //sätter språket till svenska för svensk output 
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sv-SE");
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("sv-SE");

        //Dagens datum hämtat och omvandlat till veckodag
        string today = System.DateTime.Now.ToString("dddd", new CultureInfo("sv-SE"));

        Console.WriteLine($"Idag är det {today}");


        //förbereder variabler 
        DateTime yourDate; 
        bool isValidDate = false;

        //kontroll av inmatningen av datumet samt utläsning av veckodagen 

        //skapar while loop för att se till att programmet körs tills korrekt form av datum är inmatat 
        while (!isValidDate)
        {
            //Inmatning för datum
            Console.WriteLine("Ange ett datum med följande struktur åååå, mm, dd");

            string? inputDate = Console.ReadLine(); //frågetecken efter string för den kan vara null

            //TyrParse konverterar strängen till ett datum om det är rätt inmatat och sparas i yourDate
            if (DateTime.TryParse(inputDate, out yourDate))
            {
                //Veckodagen för datumet skrivs ut 
                Console.WriteLine($"Datumet du skev var på en {yourDate.ToString("dddd", new CultureInfo("sv-SE"))}");
                return; //programmet avslutas efter att ha skrivit ut veckodag
            }
            else
            {
                //Ifall inte strängen kan konverteras till ett datum skrivs ett felmeddelande ut och man får starta om programmet 
                Console.WriteLine("Det gick inte att konvertera det du skrev. Vänligen ange korrekta värden.");
            }
        }

    }
}