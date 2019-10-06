using CollectionTest;
using CollectionTest.SimpleClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two new custom collections for Cars and Students
            CustomCollectionList<Car> myCarList = new CustomCollectionList<Car>();
            CustomCollectionList<Student> myStudentList = new CustomCollectionList<Student>();

            // fill cars collection, printout a whole collection
            int carObjectCount = FillCollectionWithCars(myCarList);
            Console.WriteLine($"Several cars were created, cars count is {carObjectCount}");
            PrintCustomCollection(myCarList);
            Console.WriteLine(new string('=', 20));

            // Find all cars with speed more than 100 and sort them by name (using reflection)
            // i don't like hardcode, need to investigate how can solve it better
            Console.WriteLine("Find all cars with speed more than 100 and sort them by name (using reflection)");
            string searchStr = "Model";
            foreach (var curCar in myCarList.FindItems(((x) => x.MaxSpeed > 100), searchStr))
            {
                Console.WriteLine(curCar.ToString());
            }
            Console.WriteLine(new string('=', 20));

            // find two cars with highest speed among cars with speed more than 100
            foreach (var curCar in myCarList.FindItems(((x) => x.MaxSpeed > 100), ((x) => x.MaxSpeed), 2))
            {
                Console.WriteLine(curCar.ToString());
            }
            Console.WriteLine(new string('=', 20));

            // remove item by ID (check realization, pls, im not sure that it is right
            string idToDelete = "Car_0002";
            if (myCarList.RemoveByID(idToDelete))
            {
                Console.WriteLine($"Item with id={idToDelete}");
                PrintCustomCollection(myCarList);
            }
            
            int studentObjectCount = FillCollectionWithStudents(myStudentList);

            Console.ReadKey();
        }
        public static int FillCollectionWithCars(CustomCollectionList<Car> curCarList)
        {
            List <(string, int)> carInitList = new List<(string, int)> ()
            {               
                ("Catmobile", 30),
                ("Patmobile", 5),
                ("Crazymobile", 1000),
                ("Fozzymobile", 250),
                ("Gendalf the Grey mobile", 50),
                ("Like a rocket mobile", 1500),
                ("Batmobile", 300)
            };
            foreach (var newCar in carInitList)
            {
                curCarList.Add(new Car(newCar.Item1,newCar.Item2));
            }
            return curCarList.NumberOfItems();
        }

        public static int FillCollectionWithStudents(CustomCollectionList<Student> curStudList)
        {
            List<(string, int, string)> studentInitList = new List<(string, int,string)>()
            {
                ("Ivanoff", 22,"ICP"),
                ("Petroff", 21,"ICP"),
                ("Sidoroff", 20,"Falkreath Hall"),
                ("Homer", 39,"Falkreath Hold"),
                ("Bart", 14,"Falkreath Hold"),
                ("Liza", 12,"Falkreath Hold"),
                ("Maggie", 35,"Kitchen"),
            };
            foreach (var newStudent in studentInitList)
            {
                curStudList.Add(new Student(newStudent.Item1, newStudent.Item2, newStudent.Item3));
            }
            return curStudList.NumberOfItems();
        }
        public static void PrintCustomCollection<T>(CustomCollectionList<T> curCollestion)
        {
            if (curCollestion.NumberOfItems()!=0)
            {
                foreach (var item in curCollestion)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
