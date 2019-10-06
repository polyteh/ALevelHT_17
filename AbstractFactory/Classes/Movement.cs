using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public interface IMovement
    {
        int Move();
    }
    public class Walk : IMovement
    {
        private int speedByFoot = 3;
        public int Move()
        {
            Console.WriteLine("Walk by foot");
            return speedByFoot;
        }
    }
    public class Ride : IMovement
    {
        private int speedWithHorse = 20;
        public int Move()
        {
            Console.WriteLine("Ride with horse");
            return speedWithHorse;
        }
    }
    public class Swim : IMovement
    {
        private int speedSwiming = 1;
        public int Move()
        {
            Console.WriteLine("Swim");
            return speedSwiming;
        }
    }
}
