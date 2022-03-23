using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    public class PracticeLesson
    {
        public void Ex_1()
        {
            Employee emp1 = new Employee(33);

            Employee emp2 = new Employee(339,true);

            emp1.id = 121;
            emp1.name = "Moshe";
            emp1.Sallary = 1000000;
            emp1.HasCar = true;
            emp1.address = "Zabotinsky";

            Student st1 = new Student()
            {
                address = "BenGurion",
                CollageName = "BarIlan",
                id = 5345,
                name = "Avi",
                phoneNumber = "345345",
                YearOfStuding = 5
            };

            DateTime d = DateTime.Today;

            st1.CommitMerried(d);
            st1.CommitMerried(d);
            st1.Devorce();
            st1.Devorce();

            //st1.merriedDate


        }
        public void Ex_2()
        {
            WorkWithFiles w = new WorkWithFiles();
            //w.SaveInFile();
            w.LoadFromCsvFile();
        }
    }
}
