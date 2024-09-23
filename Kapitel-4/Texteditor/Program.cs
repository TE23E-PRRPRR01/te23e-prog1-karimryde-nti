// Litet program för att skriva/läsa textfil
Console.Clear();
Console.WriteLine("Litet program för att skriva/läsa textfil");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

// Variabel för valet
string val = "";

// Programloop som snurrar tills användaren säger avsluta
while (true)
{
    // Visar en meny och läser användarens val
    Console.Write("""
    1. Skriv till fil
    2. Läs från fil
    3. Avsluta
    Välj ett av alternativen ovan: 
    """);
    val = Console.ReadLine();

    // Hantera användarens val
    if (val == "1")
    {
        Console.Write("Skriv in en text: ");
        string texten = Console.ReadLine();
        File.WriteAllText("filnamn.txt", texten);
    }
    else if (val == "2")
    {
        if (File.Exists("filnamn.txt"))
        {
            string texten = File.ReadAllText("filnamn.txt");
            Console.WriteLine(texten);
        }
        else
        {
            Console.WriteLine("Filen finns inte!");
        }
    }
    else if (val == "3")
    {
        Console.WriteLine("Avslutar...");
        break;
    }
    else
    {
        Console.WriteLine("Du valde inget giltigt alternativ, försök igen!");
    }
}