using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTest.SimpleClasses
{
    public class Student : Person
    {
        private static int idStudentIncreament = 0;
        private static readonly string idStudentPrefix = "St";
        private readonly string studentId;
        public Student(string studentName, int studentAge, string studentUniversity) : base(studentName, studentAge)
        {
            this.University = studentUniversity;
            this.studentId = string.Format("{0}_{1:0000}", idStudentPrefix, idStudentIncreament.ToString());
            idStudentIncreament++;
        }
        public string University { get; set; }
        public override string ID
        {
            get
            {
                return studentId;
            }
        }
    }
}
