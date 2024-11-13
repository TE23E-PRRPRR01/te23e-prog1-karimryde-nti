// Ett Dungeon-spel med massa rum, saker, fiender, skatter ..
Console.Clear();
Console.WriteLine("Ett Dungeon-spel ");

// Programvariabler (state variabels)
string rum = "hallen";
List<string> inventarie = [];
int liv = 3;

// Spelloop
while (true)
{
    // Är vi i hallen?
    if (rum == "hallen")
    {
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå till nästa rum");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du tittar i rummet och ser några gamla tavlor.");
        }
        else if (val == "2")
        {
            rum = "rum 1";
            Console.WriteLine(" .. du går in i nästa rum ..");
        }
    }
    else if (rum == "rum 1")
    {
        Console.WriteLine("Du är i rum 1");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbaka till hallen");
        Console.WriteLine("3. Gå till nästa rum");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en nyckel på golvet.");
            Console.Write("Vill du plocka upp nyckel (j/n) ");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                inventarie.Add("nyckel");
                Console.WriteLine("Du plockade upp nyckeln.");
            }
            else
            {
                Console.WriteLine("Du lämnar nyckeln på golvet!");
            }
        }
        else if (val == "2")
        {
            rum = "hallen";
            Console.WriteLine(" .. du går tillbaka till hallen ..");
        }
        else if (val == "3")
        {
            rum = "rum 2";
            Console.WriteLine(" .. du går in i nästa rum ..");
        }
    }
    else if (rum == "rum 2")
    {
        Console.WriteLine("Du är i rum 2");

        // Slumpa en händelse
        int händelse = Random.Shared.Next(1, 5);
        if (händelse == 1)
        {
            Console.Write("Du ser ett svärd på marken. Vill du plocka upp det? (j/n) ");
            string val = Console.ReadLine().ToLower();
            if (!inventarie.Contains("svärd") && val == "j")
            {
                inventarie.Add("svärd");
                Console.WriteLine("Du har nu ett svärd.");
            }
        }
        else if (händelse == 2)
        {
            Console.WriteLine("Ett spöke dyker upp");
            // ..
        }
        else if (händelse == 3)
        {
            Console.WriteLine("Du trampar på en mina och du förlorar ett liv");
            liv--;
            // Är liven slut?
            if (liv <= 0)
            {
                // Avslutar spelet
                break;
            }
        }
        else if (händelse == 4)
        {
            
        }
    }
}