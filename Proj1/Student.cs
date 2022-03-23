using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    public class Student:Person
    {
        public Student(string fileName):base(fileName)
        {

        }
        public string CollageName;
        public string phoneNumber;
        public int YearOfStuding;
    }
}
