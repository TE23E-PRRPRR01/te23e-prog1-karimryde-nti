Console.Clear();
Console.WriteLine("Hello, World!");

// Skapa en lista med 5 namn
// List<string> listaNamn = ["Karim", "Eva", "Johnny", "Arvid", "Ingrid"];
// Console.WriteLine($"Min kompisar är: {string.Join(", ", listaNamn)}");

// Skapa en lista med 5 orter
List<string> listaOrter = ["Stockholm", "Göteborg", "Malmö", "Uppsala", "Lund"];

// Fem orter (Stockholm, Göteborg, Malmö, Uppsala, Lund) ligger i Sverige.
Console.WriteLine($"Fem orter ( {string.Join(", ", listaOrter)} ) ligger i Sverige.");

// 3. Skapa en lista med 5 årtal
List<int> listaÅrtal = [1492, 1776, 1914, 1945, 1969];
Console.WriteLine($"Fem viktiga årtal är:  '{string.Join("', '", listaÅrtal)}'");

// 4. Visa första och sista objektet i en lista
//  Skapa en lista av typen List<string> som innehåller 5 namn.
List<string> listaNamn = ["Karim", "Eva", "Johnny", "Arvid", "Ingrid"];
// Visa det första och det sista namnet i listan.
