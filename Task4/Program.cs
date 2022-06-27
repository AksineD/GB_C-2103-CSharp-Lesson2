// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
PrintLine();
var date = DateTime.Now;
var name = "\"Horns and hooves\" Ltd";
Console.WriteLine($"| {name} |");
Console.WriteLine($"|   {date}   |");
PrintLine();
PrintEmpty();
Console.WriteLine("|  matches..........0.1$ |");
Console.WriteLine("|  cigarettes.....10.25$ |");
Console.WriteLine("|  soda.............2.5$ |");
PrintEmpty();
PrintLine();
PrintEmpty();
Console.WriteLine("|  Total..........10.76$ |");
PrintEmpty();
PrintLine();

void PrintLine()
{
    Console.WriteLine("+------------------------+");
}

void PrintEmpty()
{
    Console.WriteLine("|                        |");
}
