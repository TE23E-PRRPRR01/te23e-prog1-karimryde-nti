Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

// Skapa en array med några namn med dotnet-8 notation
string[] namnLista = ["Kalle", "Pelle", "Nisse", "Olle"];

// Skriv ut alla namn i listan
foreach (string namnet in namnLista)
{
    Console.WriteLine($"Namn: {namnet}");
}

Console.Write("Hej, vad heter du? ");
string namn = Console.ReadLine();

Console.WriteLine();
Console.Write($"Hej {namn}! Hur gammal är du? ");
int ålder = int.Parse(Console.ReadLine());

Console.WriteLine();
if (ålder < 18)
{
    Console.WriteLine("Du är inte myndig.");
}
else
{
    Console.WriteLine("Du är myndig.");
}
