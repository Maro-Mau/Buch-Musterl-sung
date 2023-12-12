string[] stadt = {"München", "Berlin",
    "Bonn", "Bremerhaven", "Ulm"};

for (int i = 0; i < stadt.Length; i++)
    Console.WriteLine(
        "{0,-15}{1,9:0.0000}{2,12:#,##0.0}",
        stadt[i], i / 7.0, i * 10000.0 / 7);
