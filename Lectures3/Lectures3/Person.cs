namespace Lectures3
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
            Console.WriteLine($"Creating person with name: {name}");
        }

        public Person()
        {
            Name = "Unknwon";
            Console.WriteLine("Creating Jone Doe");
        }

        public string Name { get; }

        public int Age { get; set; }

        public bool IsMale { get; set; }

        public void Greeting()
        {
            Console.WriteLine($"Hello my name is {Name} and my age is {Age}");
        }

        public void Call(string phoneNumber)
        {
            Console.WriteLine($"{Name} is calling to {phoneNumber}");
        }
    }
}
