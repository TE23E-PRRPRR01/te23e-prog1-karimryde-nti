// Bordsbokning
Console.Clear();
Console.WriteLine("Bordsbokning");

// Skapa en lista på alla bord
List<string> bordsInformation = [];

// Format på tomt bord
string tomtBordBeskrivning = "0,Inga gäster";

// Antal bord
int antalBord = 8;

// Fylla med 8 tomma bokningar
for (int i = 0; i < antalBord; i++)
{
    bordsInformation.Add(tomtBordBeskrivning);
}

// Boka ett bord
Console.Write("Ange bordsnr (1-8): ");
int bordsnr = int.Parse(Console.ReadLine());
Console.Write("Ange bokningsnamn: ");
string namn = Console.ReadLine();
Console.Write("Ange antal gäster (1-8): ");
int antalGäster = int.Parse(Console.ReadLine());
bordsInformation[bordsnr -1] = $"{antalGäster},{namn}";