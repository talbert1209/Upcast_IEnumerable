using System;

namespace Upcast_IEnumerable
{
    public class Duck : Bird, IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;
        public override string ToString()
        {
            return $"A {Size} inch {Kind}";
        }

        public void Quack()
        {

        }

        public void Swim()
        {

        }

        public void Eat()
        {

        }

        public void Walk()
        {

        }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            if (this.Size < duckToCompare.Size)
                return -1;
            return 0;
        }
    }
}