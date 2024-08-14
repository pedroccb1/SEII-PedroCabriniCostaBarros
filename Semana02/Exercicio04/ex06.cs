for(var i = 1; i <= 10, i++)
{
    Console.WriteLine(i);
}

string[] favoriteMainMetalBands = ["Van Halen", "Dokken", "Great White"];

for(var i = 0; i < favoriteMainMetalBands.Lenght, i++)
{
    Console.WriteLine(favoriteMainMetalBands[i]);
}

foreach(var band in favoriteMainMetalBands)
{
    Console.WriteLine(band);
}

favoriteMainMetalBands.ToList().ForEach{(i) => {
    Console.WriteLine("ForEach: " + i);
}};

Array.ForEach(favoriteMainMetalBands, e => Console.WriteLine("Array.forEach: " + e));