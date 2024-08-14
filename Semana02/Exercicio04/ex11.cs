using ConsoleApp;

Rat wolfRat = new Rat();
Rat fancyRat = new Rat();

wolfRat.Name = "Wolf Rat";
wolfRat.Number = 1000;
wolfRat.IsRadioactive = false;

fancyRat.Name = "Fancy Rat";
fancyRat.Number = 500;
fancyRat.IsRadioactive = false;

Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);

wolfRat.Name = "WOLF RAT";
fancyRat.Name = "FANCY RAT";

Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);

wolfRat.Name = "";
fancyRat.Name = "";

Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);