Console.Clear();
Console.WriteLine("Allt om listor");

// Skapa en tom lista
List<string> listaNamn = [];

// Infoga i en lista
listaNamn.Add("Alex");  // Verb
listaNamn.Add("Alexander");
Console.WriteLine($"Antal: {listaNamn.Count}");

// Skriv ut listan (går inte)
Console.WriteLine($"Lista: {listaNamn}");

// Skriv ut lista mha loop
foreach (var namn in listaNamn)
{
    Console.WriteLine($"- {namn}");
}

// Skriv ut första elementet i listan (index = 0)
Console.WriteLine($"Första elementet: {listaNamn[0]}");

// Skriv ut två namn ut listan
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"{i}: {listaNamn[i]}");
}

// Skriv ut alla namn i listan med for-loop
for (int i = 0; i < listaNamn.Count; i++)
{
    Console.WriteLine($"{i}: {listaNamn[i]}");
}