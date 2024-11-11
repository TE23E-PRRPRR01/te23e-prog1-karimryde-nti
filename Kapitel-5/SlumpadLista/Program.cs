// Slumpa många tal och spara i lista
Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");

// Globala variabler
// En lista för heltal
List<int> listaSlumptal = []; 

// Be användare ange antal slumpade tal
Console.Write("Ange antal slumptal: ");
int antal = int.Parse(Console.ReadLine());

// Ben användaren ange min & max slumptal
Console.Write("Ange minsta värde för slumptal: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Ange högsta värde för slumptal: ");
int max = int.Parse(Console.ReadLine());

// Loopa 5 ggr
for (int i = 0; i < antal; i++)
{
    // Slumpa ett tal 1-100
    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max + 1);

    // Lägg till slumptalet i listan
    listaSlumptal.Add(slumptal);

    Console.WriteLine($"Slumpat tal {i + 1}: {slumptal}");
}