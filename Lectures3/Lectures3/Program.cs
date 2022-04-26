

using Lectures3;

Person artis = new Person("Artis");

artis.Age = 55;
artis.IsMale = true;

string artisName = artis.Name;
Console.WriteLine($"I have created with name: {artisName}");

artis.Greeting();
artis.Call("2222222222");


Person person = new Person();

person.Age = 14;
person.IsMale = false;

person.Greeting();
person.Call("3333333333333");



Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine();



string name = "Artis";
string nameToChange = name;
nameToChange = "11111111";

Console.WriteLine($"Name is: {name}");
Console.WriteLine($"Name to change is: {nameToChange}");


Person person2 = new Person("Artis");
person2.Age = 40;

Person personToChange = person2;
personToChange.Age = 55;

Console.WriteLine($"Person age: {person2.Age}");
Console.WriteLine($"Person to change age: {personToChange.Age}");
