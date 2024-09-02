// Program som simulerar kända Engineering Flowchart
Console.Clear();
Console.WriteLine("Välkommen till ingenjörens flödesschema");

// Visa en ASCii art
Console.WriteLine(
$"""
                       -   ,--_--.
               -           \      `.
                      -     "-_ _   \
     -                         / F   )
                   -     -    / / `--'
              -              / /
                   -        / /
            -            __/ /
                        /,-pJ
           -        _--"-L ||
                  ,"      "//
     -           /  ,-"'".//\
                /  /     // J____
               J  /     // L/----\
   .           F J     //__//^---'
     `     ___J  F    '----| |
  `       J---|  F         F F
`   `. `   `--J  L        J  F
    .   .`     L J       J  F
       .  .    J  \    ,"  F
         .  `.` \  "--"  ,"
    hs      ` ``."-____-"
""");

Console.Write("Does it move? (y/n) ");
string answer = Console.ReadLine();

// Kolla om sva är ja eller nej
if (answer == "y")
{ // y = yes
    Console.Write("Should it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("No problem!");
    }
    else
    {
        Console.WriteLine("Plz use Duct Tape!");
    }
}
else
{ // n = no
    Console.Write("Should it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("Plz use WD-40!");
    }
    else
    {
        Console.WriteLine("No problem!");
    }
}