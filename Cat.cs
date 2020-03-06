using System;

namespace Pets
{
    public class Cat : Pets
    {
        public Cat(string cType, string cName, string cOwner, double cWeight) : base(cType, cName, cOwner, cWeight)
        {
            name = cName;
            owner = cOwner;
            weight = cWeight;
        }
        public string meow(int count)
        {
            int mCount = count - 1;
            for (int i = 0; i < mCount; i++)
            {
                Console.Write("Meow. ");
            }
            return "Meow.";
        }
    }
}