using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithGeneric
{
    // abstract generic factory
    public interface IFactory<TFactory>
    {
        TProduct Build<TProduct>() where TProduct : IProduct<TFactory>, new();
    }
    // concrete factories
    // car factory
    class Car : IFactory<Car>
    {
        public TProduct Build<TProduct>() where TProduct : IProduct<Car>, new()
        {
            Console.WriteLine("Creating Car: " + typeof(TProduct));
            return new TProduct();
        }
    }
    // plane factory
    class Plane : IFactory<Plane>
    {
        public TProduct Build<TProduct>() where TProduct : IProduct<Plane>, new()
        {
            Console.WriteLine("Creating Plane: " + typeof(TProduct));
            return new TProduct();
        }
    }
    class MeleeDamageDealer : IFactory<MeleeDamageDealer>
    {
        public TProduct Build<TProduct>() where TProduct : IProduct<MeleeDamageDealer>, new()
        {
            Console.WriteLine("Creating new melee damage dealer: " + typeof(TProduct));
            return new TProduct();
        }
    }

    class Factory<TFactory> where TFactory : IFactory<TFactory>, new()
    {
        public TProduct Create<TProduct>() where TProduct : IProduct<TFactory>, new()
        {
            return new TFactory().Build<TProduct>();
        }
    }
}
