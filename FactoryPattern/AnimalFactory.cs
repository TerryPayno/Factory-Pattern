using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class AnimalFactory
    {
        public IAnimal GetAnimal(string name)
        {
            switch (name)
            {
                case "Pig":
                    return new Pig();

                case "Bird":
                    return new Bird();
                default:
                    return null;
            }
        }
    }
}
