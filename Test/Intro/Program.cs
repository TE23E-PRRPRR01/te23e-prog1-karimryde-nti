﻿Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Detta är en röd text.");

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("Detta är en blå text på gul bakgrund.");

// Skapa en array med några namn med dotnet-8 notation
string[] namnLista = ["Kalle", "Pelle", "Nisse", "Olle"];

// Skriv ut alla namn i listan
foreach (string namnet in namnLista)
{
    Console.WriteLine($"Namn: {namnet}");
}
Console.ResetColor();  // Återställ färgerna till standard

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

Console.WriteLine();
Console.Write("Vilket är ditt favoritdjur? ");
string djur = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Du heter {namn}, är {ålder} år gammal och gillar {djur}.");

Console.WriteLine();
Console.WriteLine("Tack för att du deltog i testet!");

Console.WriteLine();