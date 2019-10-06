using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithGeneric
{
    public class CarProduct
    {
        public class Honda : IProduct<Car>
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

        public class Toyota : IProduct<Car>
        {
            public void Operate()
            {
                Console.WriteLine("Driving Toyota.");
            }

            public void ToyotaSpecificOperation()
            {
                Console.WriteLine("Performing Toyota-specific operation.");
            }
        }

        public class Boeing : IProduct<Plane>
        {
            public void Operate()
            {
                Console.WriteLine("Flying Boeing.");
            }

            public void BoeingSpecificOperation()
            {
                Console.WriteLine("Performing Boeing-specific operation.");
            }
        }

        public class Saab : IProduct<Car>, IProduct<Plane>
        {
            public void Operate()
            {
                Console.WriteLine("Operating Saab.");
            }

            public void SaabSpecificOperation()
            {
                Console.WriteLine("Performing Saab-specific operation.");
            }
        }
    }
}
