Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Samlingar");

// Skapa en tom lista av strängar
List<string> listaBöcker = [];

// Skapa en lista med filmnamn
// List<string> listaFilmer= ["2001", "I Robot", "Scarface"];

// Skriv ut alla filmnamn
// Console.WriteLine($"Alla filmer: {string.Join(", ", listaFilmer)}");

// Lägga till i en lista
listaBöcker.Add("Pippi");
Console.WriteLine($"Alla böcker: {string.Join(", ", listaBöcker)}");
// listaFilmer.Add("Black Which");
// Console.WriteLine($"Alla filmer: {string.Join(", ", listaFilmer)}");

// Användaren anger en bok
Console.Write("Ange en bok att lägga till: ");
string nyBok = Console.ReadLine();
listaBöcker.Add(nyBok);
Console.WriteLine($"Alla böcker: {string.Join(", ", listaBöcker)}");

// Kolla om en bok finns i listan?
// Om den finns ta bort den
Console.Write("Vilken bok söker du? ");
nyBok = Console.ReadLine();

if (listaBöcker.Contains(nyBok))
{
    Console.WriteLine("Den finns");
    listaBöcker.Remove(nyBok);
}
else
{
    Console.WriteLine("Den finns inte");
}
Console.WriteLine($"Alla böcker: {string.Join(", ", listaBöcker)}");