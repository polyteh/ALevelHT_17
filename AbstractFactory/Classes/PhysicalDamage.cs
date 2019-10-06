using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public interface IPhysicalDamage
    {
        int MakeHit();
    }
    public class HitWithSword : IPhysicalDamage
    {
        private const int _defaultSwordStrength = 10;
        private int _swordStrength;

        public HitWithSword(int weaponStrenght = _defaultSwordStrength)
        {
            this._swordStrength = weaponStrenght;
        }
        public int MakeHit()
        {
            Console.WriteLine("Swordsman");
            return _swordStrength;
        }
    }
    public class HitWithSpear : IPhysicalDamage
    {
        private const int _spearStrength = 12;
        public int MakeHit()
        {
            Console.WriteLine("Spearman");
            return _spearStrength;
        }
    }
    public class HitWithBow : IPhysicalDamage
    {
        private const int _bowStrength = 5;
        public int MakeHit()
        {
            Console.WriteLine("Bowman");
            return _bowStrength;
        }
    }
    public class NoPhysicalDamageWarrior : IPhysicalDamage
    {
        private const int _noPhysicalDamage = 0;
        public int MakeHit()
        {
            Console.WriteLine("No physical damage");
            return _noPhysicalDamage;
        }
    }
}
