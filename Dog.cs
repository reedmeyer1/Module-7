using System;

namespace Pets
{
    public class Dog : Pets
    {
        public Dog(string dType, string dName, string dOwner, double dWeight) : base(dType, dName, dOwner, dWeight)
        {
            name = dName;
            owner = dOwner;
            weight = dWeight;
        }
        public string bark(int count)
        {
            int bCount = count - 1;
            for (int i = 0; i < bCount; i++)
            {
                Console.Write("Bark!");
            }
            return "Bark!";
        }
    }
}