using System;

namespace Pets
{
    public class Pets
    {
        protected string type;
        protected string name;
        protected string owner;
        protected double weight;
        public Pets(string pType, string pName, string pOwner, double pWeight)
        {
            type = pType;
            name = pName;
            owner = pOwner;
            weight = pWeight;
        }
        public string getTag()
        {
            return "If lost call: " + owner;
        }
        static void Main(string[] args)
        {
            Pets pet1 = new Pets("dog", "Shadow", "Jose", 42.6);     
            Console.Write("Name: " + pet1.name + "\r\n");
            Console.Write("Weight: " + pet1.weight + " lbs" + "\r\n");
            Console.Write(pet1.getTag());
            Console.Write("\r\n");
            Console.Write("\r\n");

            Dog dog1 = new Dog("dog", "Daisy", "Kent", 23.4);

            Console.Write("Name: " + dog1.name + "\r\n");
            Console.Write("Weight: " + dog1.weight + " lbs" + "\r\n");
            Console.Write(dog1.getTag() + "\r\n");
            Console.Write(dog1.bark(4));
            Console.Write("\r\n");
            Console.Write("\r\n");

            Cat cat1 = new Cat("cat", "Simba", "Maria", 5.2);

            Console.Write("Name: " + cat1.name + "\r\n");
            Console.Write("Weight: " + cat1.weight + " lbs" + "\r\n");
            Console.Write(cat1.getTag() + "\r\n");
            Console.Write(cat1.meow(3));
        }
    }
}
