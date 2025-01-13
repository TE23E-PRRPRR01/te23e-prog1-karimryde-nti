/* *****************************************************
* ********************  M A I N ************************
******************************************************* */
Console.Clear();

// Skriv ett meddelande vertikalt
string meddelande = "Måndag!";
// SkivVertikalt(meddelande);

// Skriv ett meddelande vertikalt nr 2
string meddelande1 = "Tisdag är bättre!";
// SkivVertikalt(meddelande1);

// Skriv ett meddelande vertikalt nr 3
string meddelande2 = "Tisdag är bättre!";
// SkivVertikalt(meddelande2);

// Rita ut en fyrkant med sidlängd 3
// RitaKvadrat(3);
// Console.WriteLine();
// RitaKvadrat(4);

// Testar metoden UpprepaText
// UpprepaText("hej", 3);
// UpprepaText("Hejsan", 5);

// Testa metode OmvandlaCTillF
//OmvandlaCTillF(37);

KastaTärning(6);

/* *****************************************************
* ********************  M E T O D E R *******************
******************************************************* */
/// <summary>
/// Skriv ett meddelande vertikalt
/// </summary>
/// <param name="meddelande"></param>
static void SkivVertikalt(string meddelande)
{
    for (int i = 0; i < meddelande.Length; i++) // 0 -> 6
    {
        Console.WriteLine(meddelande[i]);
    }
}

static void RitaKvadrat(int sidlängd)
{
    for (int i = 0; i < sidlängd; i++)
    {
        for (int j = 0; j < sidlängd; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}


static void UpprepaText(string text, int antal)
{
    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine(text);
    }
}

static void OmvandlaCTillF(int celsius)
{
    int fahrenheit = celsius * 9/5 + 32;
    Console.WriteLine($"{celsius} grader Celsius motsvarar {fahrenheit} grader Fahrenheit");
}

static void KastaTärning(int antal)
{
    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine($"Tärningen visar {Random.Shared.Next(1, 7)}");
    }
}