using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTest.SimpleClasses
{
    public class Car : IInfo
    {
        // some staff for ID managment
        private static int idCarIncreament = 0;
        private static readonly string idCarPrefix = "Car";
        private readonly string carId;
        public Car(string carModel, int carMaxSpeed)
        {
            this.Model = carModel;
            this.MaxSpeed = carMaxSpeed;
            this.carId = string.Format("{0}_{1:0000}", idCarPrefix, idCarIncreament);
            idCarIncreament++;

        }

        // several properties
        public string Model { get; private set; }
        public int MaxSpeed { get; private set; }

        public string ID
        {
            get
            {
                return this.carId;
            }
        }

        public override string ToString()
        {
            return $"{this.carId,-6}|{this.Model,-30}|{this.MaxSpeed.ToString(),3}";
        }


    }
}
