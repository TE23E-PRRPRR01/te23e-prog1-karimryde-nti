/* *****************************************************
* ********************  M A I N ************************
******************************************************* */

Console.Clear();
Console.WriteLine("Hej Metoder!");

SägHejNamn("Valentin");
SägHejNamn("Johnny");
SägHejNamn("Benjamin");
SägHejNamn("");
KvadreraTal(3);


/* *****************************************************
* ******************  M E T O D E R ********************
******************************************************* */

/// <summary>
/// Skriv ut hälsning
/// </summary>
/// <param name="namn">Namnet</param>
static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på dig {namn}!");
}

/// <summary>
/// Metod som skriver ett tal i kvadrat!
/// </summary>
/// <param name="tal"></param>
static void KvadreraTal(int tal)
{
    Console.WriteLine($"{tal} i kvadrat = {tal * tal}");
}