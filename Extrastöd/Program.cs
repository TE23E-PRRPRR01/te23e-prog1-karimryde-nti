using System.Runtime.Intrinsics.Arm;

Console.Clear();
Console.WriteLine("Listor!");
Console.WriteLine();

// Skapa en tom lista för pizzarätter
List<string> pizzas = [];

// Skapa en tom lista för frukter
List<string> frukter = [];

// Skapa en tom lista på skostorlekar
List<int> skostorlekar = [];

// Skapa en lista med tre förnamn
List<string> namnlista = ["Anders", "Anna", "Åke"];

// Lägg till i listor med .Add()
// Lägg till tre pizzor
pizzas.Add("Carbonara");
pizzas.Add("Vesuvius");
pizzas.Add("Kebabpizza");

// Lägg till tre frukter i listan frukter
frukter.Add("Annanas");
frukter.Add("Banan");
frukter.Add("Äpple");

// Skriv ut alla frukter
foreach (var frukt in frukter)
{
    Console.WriteLine($"Frukt: {frukt}");
}

// Låt användaren mata in en 4:e pizza


// Skriv ut alla pizzor
foreach (var pizza in pizzas)
{
    Console.WriteLine($"- {pizza}");
}

// Låt användaren mata in en 4:e namn
Console.Write("Vad heter du? ");
string nynamn = Console.ReadLine();
namnlista.Add(nynamn);

// Skriv ut alla namn
foreach (var namn in namnlista)
{
    Console.WriteLine(namn);
}

// Nu låter vi användaren mata in skostorlekar
Console.WriteLine("Ange din skostorlek: ");
int input = int.Parse(Console.ReadLine());
skostorlekar.Add(input);

// Skriv skostorlekar
foreach (var skostorlek in skostorlekar)
{
    Console.WriteLine($"* {skostorlek}");
}

// Hur många pizzor har vi?
int antal = pizzas.Count;
Console.WriteLine($"Totalt antal pizzor = {antal}");

// Hur många frukter?
Console.WriteLine($"Totalt antal frukter = {frukter.Count}");

// Hur många namn har vi i listan?
Console.WriteLine($"Totalt antal namn = {namnlista.Count}");

// Skriv ut första namnet
Console.WriteLine($"Första namnet är {namnlista[0]}");

// Skriv ut andra namnet
Console.WriteLine($"Andra namnet är {namnlista[1]}");

// Skriv ut sista namnet
Console.WriteLine($"Sista namnet är {namnlista[3]}");

// Byta ut första namn med annat namn
namnlista[0] = "Andreas";

// Skriv ut första namnet
Console.WriteLine($"Första namnet är {namnlista[0]}");

// Byt ut andra namnet med ??? och skriv ut
namnlista[1] = "Filip";
Console.WriteLine($"Andra namnet är {namnlista[1]}");

// Be användaren byta ut första pizzan
Console.Write("Ange ny första pizza: ");
string nypizza = Console.ReadLine();
pizzas[0] = nypizza;

// Be användaren vilken pizzas som skall bytas ut
Console.Write("Vilken pizza vill du byta ut (0, 1, 2): ");
int index = int.Parse(Console.ReadLine());

// Be användaren vad heter nya pizzan
Console.Write("Vad heter nya pizzan: ");
nypizza = Console.ReadLine();
pizzas[index] = nypizza: