string? s;
Console.Write("Bitte einen Text eingeben: ");
s = Console.ReadLine();
Console.WriteLine($"Text {s} eingegeben");

double x;
Console.WriteLine();
try
{
    Console.Write("Bitte eine Zahl eingeben: ");
    x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Zahl {x} eingegeben");
}
catch
{
    Console.WriteLine("Keine Zahl eingegeben");
}

int a;
Console.WriteLine();
do
{
    try
    {
        Console.Write("Bitte ganze Zahl eingeben: ");
        a = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Fehler, bitte noch einmal");
    }
}
while (true);
Console.WriteLine($"Ganze Zahl {a} eingegeben");
