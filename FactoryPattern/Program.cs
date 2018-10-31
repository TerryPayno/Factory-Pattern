using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory Fact = new AnimalFactory();

            Console.WriteLine("What Animal do you want to test?");
            string name = Console.ReadLine();

            IAnimal animal = Fact.GetAnimal(name);
            animal.TryToFly();
            Console.ReadLine();
        }
    }
}
