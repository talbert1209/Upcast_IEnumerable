using System;
using System.Collections.Generic;

namespace Upcast_IEnumerable
{
    class Program
    {
        public static void PrintDucks(List<Duck> listOfDucks)
        {
            foreach (var duck in listOfDucks)
            {
                Console.WriteLine(duck);
            }

            Console.WriteLine("End of ducks!");
        }

        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() {Kind = KindOfDuck.Mallard, Size = 17},
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck() {Kind = KindOfDuck.Decoy, Size = 14},
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck() {Kind = KindOfDuck.Mallard, Size = 14},
                new Duck() {Kind = KindOfDuck.Decoy, Size = 13},
            };

            IEnumerable<Bird> upcastDucks = ducks;

            List<Bird> birds = new List<Bird>();

            birds.Add(new Bird() {Name = "Feathers"});
            birds.AddRange(upcastDucks);
            birds.Add(new Penguin() {Name = "George"});

            foreach (var bird in birds)
            {
                Console.WriteLine(bird);
            }
            

            Console.ReadKey();
        }
    }
}
