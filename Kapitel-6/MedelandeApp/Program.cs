/* **************************
* ******** M A I N ********
************************** */
VisaPresentation();

// Variabler
string filnamn = "meddelande.txt";

// Programloopen
while (true)
{
    VisaMeny();
    string val = Console.ReadLine();

    if (val == "1")
    {
        SparaMeddelande(filnamn);
    }
    else if (val == "2")
    {
        LäsaMeddelande(filnamn);
    }
    else if (val == "3")
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else
    {
        Console.WriteLine("Fel val! Försök igen!");
    }
}

/* **************************
* ******** METODER *********
************************** */
/// <summary>
/// Presentation av programmet
/// </summary>
static void VisaPresentation()
{
    Console.Clear();
    Console.WriteLine("""
    ==========================================
    Program för att spara meddelande på disken
    Av xxx yyyy 2025
    ==========================================
    """);
}

/// <summary>
/// Visar programmets meny med alla funktioner
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""

    1. Spara meddelande
    2. Läsa meddelande
    3. Avsluta programmet
    """);
    Console.Write("Ange ditt val: ");
}

/// <summary>
/// Sparar ned ett meddelande i en textfil
/// </summary>
static void SparaMeddelande(string filen)
{
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine();
    File.WriteAllText(filen, meddelande);
    Console.WriteLine("Ditt meddelande har sparats!");
}

/// <summary>
/// Läser in från textfilen och skriver meddelandet
/// </summary>
static void LäsaMeddelande(string filen)
{
    string meddelande = File.ReadAllText(filen);
    Console.WriteLine("Ditt senaste meddelande:");
    Console.WriteLine("---------------");
    Console.WriteLine(meddelande);
    Console.WriteLine("---------------");
}