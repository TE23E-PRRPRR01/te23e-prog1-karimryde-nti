Console.Clear();
Console.WriteLine("Temperaturlogg!");

// En list för att lagra 7 temperaturer
List<int> temperaturer = [];

// Loopa 7 ggr
for (int i = 0; i < 7; i++)
{
    // Fråga användaren
    Console.Write($"Ange en temperatur {i + 1}: ");
    string temperaturText = Console.ReadLine();
    bool success = int.TryParse(temperaturText, out int temperatur);

    // Lägg till i listan
    temperaturer.Add(temperatur);
}

// Räkna ut medel
Console.WriteLine();
int summa = 0;
foreach (var temp in temperaturer)
{
    summa += temp;
}
Console.WriteLine($"Medel = {summa / 7}");

Console.WriteLine();
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"Dag {i + 1}: {temperaturer[i]}");
}

// Byta ut temperatur för en vald dag
Console.Write("Ange dag för att ändra temperatur (1-7):");
string dagText = Console.ReadLine();
bool success = int.TryParse(dagText, out int dag);

Console.Write($"Ange ny temperatur för dag {dagText}:");
string temperaturText = Console.ReadLine();
success = int.TryParse(temperaturText, out int temperatur);

temperaturer[dag - 1] = temperatur;
Console.WriteLine($"Temperaturen för dag {dag} har ändrats till {temperatur}.");

// Avslutar! Skriv ut alla temperaturer
Console.WriteLine();
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"Dag {i + 1}: {temperaturer[i]}");
}