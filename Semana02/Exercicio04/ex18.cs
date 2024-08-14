Person person1 = new("Teddy", "Smith", new string[1] { "555-1234" });
Person person2 = new("Teddy", "Smith", new string[1] { "555-1234" });

person1.LastName = "smith";
person1.PhoneNumbers[0] = "222-2222";

Console.WriteLine(person1 == person2);

Person person3 = person2 with { LastName = "Brewski" };
Console.WriteLine(person3.ToString());

public record Person(string FirstName, string LastName, string[] PhoneNumbers);