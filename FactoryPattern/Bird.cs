using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Bird : IAnimal
    {
        public void TryToFly()
        {
            Console.WriteLine("I can fly!");
        }
    }
}
