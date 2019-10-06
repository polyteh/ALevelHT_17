using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public interface IMagicDamage
    {
        int CastSpell();
    }
    public class CastInferno : IMagicDamage
    {
        private int infernoDamage = 10;
        public int CastSpell()
        {
            Console.WriteLine("Fire magic adept");
            return infernoDamage;
        }
    }
    public class CastChainLightning : IMagicDamage
    {
        private int chainLightningStrength = 15;
        public int CastSpell()
        {
            Console.WriteLine("Air magic adept");
            return chainLightningStrength;
        }
    }
    public class CastIceBolt : IMagicDamage
    {
        private int iceBoltStrength = 3;
        public int CastSpell()
        {
            Console.WriteLine("Water magic adept");
            return iceBoltStrength;
        }
    }
    public class NoMagicDamageWarrior : IMagicDamage
    {
        private int noMagicDamage = 0;
        public int CastSpell()
        {
            Console.WriteLine("No magic");
            return noMagicDamage;
        }
    }

}
