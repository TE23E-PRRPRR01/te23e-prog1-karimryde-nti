/* *****************************************************
* ******************  M A I N  *************************
******************************************************* */
// Använd metoder här!
// int svar = Addera(3, 5);
// Console.WriteLine($"Svaret är {svar}");
// Console.WriteLine(Addera(3, 5));
// Console.WriteLine($"3 + 5 = {Addera(3, 5)}");

string namn = "Joan";
Console.WriteLine($"{namn} baklänges är {VändText(namn)}");

Console.Write("Ange ett tal: ");
int nyTal1 = LäsInHeltal();

Console.Write("Ange ett tal: ");
int nyTal2 = LäsInHeltal();



/* *****************************************************
* ******************  M E T O D E R ********************
******************************************************* */
// Skapa metoder här!

/// <summary>
/// Summera två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static int Addera(int tal1, int tal2) // signatur
{
    int summa = tal1 + tal2;
    return summa;
}

/// <summary>
/// Vänder på texten
/// </summary>
/// <param name="text"></param>
static string VändText(string text)
{
    string omvändText = "";
    for (int i = text.Length - 1; i >= 0; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}

/// <summary>
/// Säkert sätt att läsa in ett tal (utan att det kraschar)
/// </summary>
static int LäsInHeltal()
{
    while (true)
    {
        // Läs in från användaren
        string textSomBlirTal = Console.ReadLine();

        // Kolla om texten är ett tal
        bool lyckades = int.TryParse(textSomBlirTal, out int tal);
        
        if (lyckades == true)
        {
            return tal;
        }
        else
        {
            Console.WriteLine("Fel! Vg ang ett heltal!");
        }
    }
}