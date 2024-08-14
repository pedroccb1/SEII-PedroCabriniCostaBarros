using System.Text;

string petFish = "puffer fish";

petFish = "porcupine" + petFish;

StringBuilder newCrustacean = new StringBuilder();
newCrustacean.Append("fiddler crab");
Console.WriteLine(newCrustacean);
newCrustacean.Remove(0, 8);
Console.WriteLine(newCrustacean);