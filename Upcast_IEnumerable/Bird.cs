using System;

namespace Upcast_IEnumerable
{
    public class Bird
    {
        public string Name { get; set; }

        public virtual void Fly()
        {
            Console.WriteLine("Flap, Flap");
        }

        public override string ToString()
        {
            return $"A bird named {Name}";
        }
    }
}