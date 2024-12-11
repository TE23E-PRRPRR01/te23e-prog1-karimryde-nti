Console.Clear();
Console.WriteLine("Filmregister");

// Lista för att lagra filmer
List<string> listaFilmer = [];

// Be användaren ange ett antal
Console.Write("Ange antal filmer per sida (3-5): ");
string antalText = Console.ReadLine();
int antal = 0;
while (true)
{
    bool success = int.TryParse(antalText, out antal);
    if (success)
    {
        break;
    }
    else
    {
        Console.WriteLine("Fel! Vg mata ett heltal.");
    }
}

// Programloop
while (true)
{
    // Visa en meny
    Console.Write("""
1. Lägg till filmer
2. Skriv ut alla filmer
3. Sök en film
4. Avsluta
Välj ett alternativ: 
""");
    string val = Console.ReadLine();
    Console.WriteLine();

    // Hanterar med valet
    if (val == "1")
    {
        // Lägg till filmer i lisan
        for (int i = 0; i < antal; i++)
        {
            Console.Write("Ange en film att lägga til: ");
            string film = Console.ReadLine();
            listaFilmer.Add(film);
        }
    }
    else if (val == "2")
    {
        // Skriv ut alla filmer
        foreach (var filmnamn in listaFilmer)
        {
            Console.WriteLine($"- {filmnamn}");
        }
    }
    else if (val == "3")
    {
        // Sök en film
        Console.Write("Ange en film att söka efter (första bokstaven): ");
        string bokstav = Console.ReadLine();
        foreach (var filmnamn in listaFilmer)
        {
            // Kolla om varje film börjar på bokstaven
            if (filmnamn.StartsWith(bokstav))
            {
                Console.WriteLine($"- {filmnamn}");
            }
        }
    }
    else if (val == "4")
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else
    {
        Console.WriteLine("Fel val. Försök igen!");
    }
}