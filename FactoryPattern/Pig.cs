using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Pig: IAnimal
    {
        public void TryToFly()
        {
            Console.WriteLine("Pigs can't fly!");
        }
    }
}
