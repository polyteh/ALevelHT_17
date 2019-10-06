using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryWithGeneric.CarProduct;

namespace AbstractFactoryWithGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory<Car> carFactory = new Factory<Car>();
            IProduct<Car> carProduct = carFactory.Create<Toyota>();
            carProduct.Operate();
            ((Toyota)carProduct).ToyotaSpecificOperation();

            Honda honda = carFactory.Create<Honda>();
            honda.Operate();
            honda.HondaSpecificOperation();

            Console.ReadKey();
        }
    }
}
