using System;

namespace Upcast_IEnumerable
{
    public class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penguins can't fly!");
        }

        public override string ToString()
        {
            return $"A penguin Named {Name}";
        }
    }
}