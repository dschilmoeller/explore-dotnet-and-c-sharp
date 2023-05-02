using FoodStuff; // uses the namespace in food.cs

// int[] array1 = new int[] { 1, 3, 5, 7, 9 };
// foreach(int n in array1)
// {
//     Console.WriteLine("array n is: " + array1[n]);
// }

string[] names = { "Key", "Kris", "Emma" };
foreach (string n in names)
{
    // Console.WriteLine(n);
}

// .NET List:
List<string> shoeList = new List<string>();
// List = class. < > = data type. Shoelist = var name. () = function? Create?
// List<data-type> variableName = new List<data-type>(); 
shoeList.Add("Nike");
shoeList.Add("Adidas");
shoeList.Add("New Balance");
foreach (string shoe in shoeList)
{
    Console.WriteLine(shoe);
}
// Does this work?
Console.WriteLine(shoeList.ToString());
// Nope. Too complicated.

// Classes
// distinct from but related to Objects
// Object Oriented Programming - focused on the object, programming built out around that. Has properties.
// Class Oriented Programming - focused on templates (classes) of which objects are sub-pieces? of.
    // Broadly, can get more specific as one goes down a tree.
    // e.g. Writing Utensils = [Pens, Markers, Pencils]
    // Pens = [Bic, Pilot]

// Data Type is Food
// Variable name is myZa 
// caps generally indicate a class (ie. data type)
Food myZa = new Food();
// 'new' indicates a NEW instance (object) of the specified class.
Console.WriteLine($"My lunch is: {myZa.kind}");

Pizza pepperoni = new Pizza();

pepperoni.Cook();

Food yourZa = new Food();
// yourZa as written will be Pizza.
Console.WriteLine($"Your {yourZa.kind} has {yourZa.remaining} percent left.");

Console.WriteLine($"My za is at temp of {myZa.GetTemp()}");
myZa.Cook();
Console.WriteLine($"My za is at temp of {myZa.GetTemp()}");
myZa.Cook();
Console.WriteLine($"My za is at temp of {myZa.GetTemp()}");
myZa.Cook();
Console.WriteLine($"Pepperoni is at temp of {pepperoni.GetTemp()}");
pepperoni.Cook();
Console.WriteLine($"Pepperoni is at temp of {pepperoni.GetTemp()}");
pepperoni.Cook();
