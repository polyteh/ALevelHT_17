using AbstractFactory.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero walkedDefaultSwordsman = new Hero(new WalkedSwordsman(60));
            int walkedDefaultSwordsmanDamage = walkedDefaultSwordsman.MakePhysicalDamage();
            Console.WriteLine($"Walked swordsman damage is {walkedDefaultSwordsmanDamage}");
            int walkedDefaultSwordsmanHealth = walkedDefaultSwordsman.CurrentHealth();
            Console.WriteLine($"Walked swordsman health is { walkedDefaultSwordsmanHealth}");


            Hero rideEliteSwordsman = new Hero(new EliteRideSwordsman(90, 60));
            int rideEliteSwordsmanDamage = rideEliteSwordsman.MakePhysicalDamage();
            Console.WriteLine($"Ride elite swordsman damage is {rideEliteSwordsmanDamage}");
            int rideEliteSwordsmanHealth = rideEliteSwordsman.CurrentHealth();
            Console.WriteLine($"Ride elite swordsman health is {rideEliteSwordsmanHealth}");

            Console.ReadKey();
        }

    }
}
