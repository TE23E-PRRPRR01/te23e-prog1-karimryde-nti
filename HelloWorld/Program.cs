Console.Clear();

Console.WriteLine("Hej världen!");
Console.WriteLine("Nu mitt första C#-program");

Console.Write("Vad heter du? ");
string namn = Console.ReadLine();
Console.WriteLine("Hej " + namn);

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Såg du på OS i sommar?");
Console.WriteLine("Vilken sport gillar du mest?");