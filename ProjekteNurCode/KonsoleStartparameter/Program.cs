double summe = 0;

for (int i = 0; i < args.Length; i++)
    Console.WriteLine($"{i}: {args[i]}");

for (int i = 0; i < args.Length; i++)
{
    try
    {
        summe += Convert.ToDouble(args[i]);
    }
    catch { }
}

Console.WriteLine($"Summe: {summe}");
