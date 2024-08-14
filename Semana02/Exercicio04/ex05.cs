string[] favoriteRats = ["fancy rat", "crown rat", "radioactive rat", "wolf rat"];

var newFavoriteRats = favoriteRats.Where((e) => e.StartsWith("b"))

foreach(var rat in favoriteRats)
{
    Console.WriteLine(rat);
}

