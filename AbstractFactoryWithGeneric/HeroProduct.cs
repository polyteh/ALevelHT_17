using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithGeneric
{

    public class Swardsman : IProduct<MeleeDamageDealer>
    {
        public void Operate()
        {
            Console.WriteLine("Driving Honda.");
        }

        public void HondaSpecificOperation()
        {
            Console.WriteLine("Performing Honda-specific operation.");
        }
    }

}
