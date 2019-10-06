using AbstractFactory.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractHeroFactory

    {
        private const int _defaultHealth = 50;
        private int _heroHealth;
        public AbstractHeroFactory(int heroHealth = _defaultHealth)
        {
            this._heroHealth = heroHealth;
        }
        public abstract IPhysicalDamage MakePhysicalDamage();
        public abstract IMagicDamage MakeMagicDamage();

        public abstract IMovement MakeMovement();
        public int Health
        {
            get
            {
                return _heroHealth;
            }
        }
    }
    class WalkedSwordsman : AbstractHeroFactory
    {
        public WalkedSwordsman(int heroHealth) : base(heroHealth)
        {

        }
        public override IPhysicalDamage MakePhysicalDamage()
        {
            return new HitWithSword();
        }
        public override IMagicDamage MakeMagicDamage()
        {
            return new NoMagicDamageWarrior();
        }
        public override IMovement MakeMovement()
        {
            return new Walk();
        }
    }
    class EliteRideSwordsman : AbstractHeroFactory
    {
        private int _eliteSwardsmanDamage;
        public EliteRideSwordsman(int heroHealth, int eliteSwardsmanDamage) : base(heroHealth)
        {
            this._eliteSwardsmanDamage = eliteSwardsmanDamage;
        }
        public override IPhysicalDamage MakePhysicalDamage()
        {
            return new HitWithSword(_eliteSwardsmanDamage);
        }
        public override IMagicDamage MakeMagicDamage()
        {
            return new NoMagicDamageWarrior();
        }
        public override IMovement MakeMovement()
        {
            return new Ride();
        }
    }
    class RideFireMage : AbstractHeroFactory
    {
        public override IPhysicalDamage MakePhysicalDamage()
        {
            return new NoPhysicalDamageWarrior();
        }
        public override IMagicDamage MakeMagicDamage()
        {
            return new CastInferno();
        }
        public override IMovement MakeMovement()
        {
            return new Ride();
        }
    }
    public class Hero
    {
        private IPhysicalDamage _makePhysicalDamage;
        private IMagicDamage _makeMagicDamage;
        private IMovement _makeMovement;
        private int _heroHealth;

        private AbstractHeroFactory _newHerofactory;
        // а вот тут вопрос: как лучше получать доступ к функционалу конкретной фабрики
        // 1) сделать приватные поля на каждый метод абстрактной фабрики
        // 2) сделать инстанс абстрактной фабрики (дефакто туда пишется наследник-конкретная фабрика) фабрики и работать через него
        
        // пример контравариации??
        public Hero(AbstractHeroFactory newHeroFactory)
        {
            _makePhysicalDamage = newHeroFactory.MakePhysicalDamage();
            _makeMagicDamage = newHeroFactory.MakeMagicDamage();
            _makeMovement = newHeroFactory.MakeMovement();
            _heroHealth = newHeroFactory.Health;
            this._newHerofactory = newHeroFactory;
        }

        public int MakePhysicalDamage()
        {

            //int physicalDamage = ((IPhysicalDamage)_newHerofactory.MakePhysicalDamage()).MakeHit();
            //return physicalDamage;
            return _makePhysicalDamage.MakeHit();
        }
        public int MakeMagicDamage()
        {

            return _makeMagicDamage.CastSpell();
        }
        public int MakeMovement()
        {
          
            return _makeMovement.Move();
        }
        public int CurrentHealth()
        {
            return _newHerofactory.Health;
        }

    }

}
