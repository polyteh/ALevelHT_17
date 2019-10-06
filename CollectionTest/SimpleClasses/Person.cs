using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTest.SimpleClasses
{
    public abstract class Person : IInfo
    {
        public Person(string personName, int personAge)
        {
            this.Name = personName;
            this.Age = personAge;
        }
        public abstract string ID { get; }
        public string Name { get; private set; }
        public int Age { get; set; }
    }
}
