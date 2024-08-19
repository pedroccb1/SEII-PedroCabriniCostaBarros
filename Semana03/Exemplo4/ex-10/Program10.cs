
using System.Runtime.InteropServices.Marshalling;
using Binnary_Trees;

BinarySearchTree bin = new BinarySearchTree();
bin.Insert(5, "Gengar");
bin.Insert(21, "Snorlax");
bin.Insert(147, "Dragonite");
bin.Insert(9, "Pikachu");

Console.WriteLine(bin.Find(147));