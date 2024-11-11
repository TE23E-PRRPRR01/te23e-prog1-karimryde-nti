// Skapa lista med slumpade tal

/* *******************************************************
**                          Main                        **
******************************************************** */

// Validera användrens inmatning
Console.Clear();
Console.WriteLine("Hello, World!");

// Deklarera variabler
// Skapa en tom lista för att spara des slumpade talen
List<int> listaSlumptal = [];

// Fråga igen tills användaren matar in ett giltigt svar
int antal = LäsInHeltal();
Console.WriteLine($"Du vill ha {antal} slumptal!");

// Användaren mata in min-värde 
int min = LäsInHeltal();
Console.WriteLine($"Lägsta slumptal blir {min}!");

// Användaren mata in max-värde
int max = LäsInHeltal();
Console.WriteLine($"Högsta slumptal blir {max}!");

// Slumpa fram ett antal  tal
for (int i = 0; i < antal; i++)
{
    int slumptal = Random.Shared.Next(min, max + 1);
    Console.WriteLine($"Ditt nya slumptal är {slumptal}");
}

/* *******************************************************
**                  Mina egna metoder                    **
******************************************************** */

static int LäsInHeltal()
{
    int heltal = 0;
    while (true)
    {
        Console.Write("Ange heltal: ");

        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades)
        {
            break;
        }
        else
        {
            Console.WriteLine("Du måste skriva ett heltal");
        }
    }
    return heltal;
}