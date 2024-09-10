 
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
string today = System.DateTime.Now.DayOfWeek.ToString(); 

Console.WriteLine($"Today it is {today}"); 

//Inmatning för datum
Console.WriteLine("Ange ett datum med följande struktur åååå-mm-dd"); 

string? yourDate = Console.ReadLine(); //frågetecken efter string för den kan vara null

Console.WriteLine($"Datumet {yourDate} var på en veckodag"); //hur ska man göra omvandlingen? 