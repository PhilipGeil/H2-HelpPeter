using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpPeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Penguin penguin = new Penguin();
            Pigeon pigeon = new Pigeon();
            List<Bird> birds = new List<Bird>() { penguin, pigeon };

            foreach (Bird bird in birds)
            {
                if (bird is IFly)
                {
                    Console.WriteLine(bird.ToString());
                    Console.WriteLine("I Fly");
                } else
                {
                    Console.WriteLine(bird.ToString());
                    Console.WriteLine("I don't fly");
                }
            }
            Console.ReadKey();
        }
    }
}
