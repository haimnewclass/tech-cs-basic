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
            Employee emp1 = new Employee(33, "MosheData.csv");

            Employee emp2 = new Employee(339, true, "MosheData2.csv");

            emp1.id = 121;
            emp1.name = "Moshe";
            emp1.Sallary = 1000000;
            emp1.HasCar = true;
            emp1.address = "Zabotinsky";

            emp1.Save("MosheData.csv");


            Student st1 = new Student("AviData.csv")
            {
                address = "BenGurion",
                CollageName = "BarIlan",
                id = 5345,
                name = "Avi",
                phoneNumber = "345345",
                YearOfStuding = 5
            };

            st1.Save("AviData.csv");

            DateTime d = DateTime.Today;

            st1.CommitMerried(d);
            st1.CommitMerried(d);
            st1.Devorce();
            st1.Devorce();

            st1.CommitMerried(DateTime.Now);

            st1.Save("AviData.csv");
            st1.Load("AviData.csv");


        }
        public void Ex_2()
        {
            WorkWithFiles w = new WorkWithFiles();
            //w.SaveInFile();
            w.LoadFromCsvFile();
        }

        public void Ex_3()
        {
            Student s = new Student("klum");
            Console.WriteLine("Enter Id");
            s.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            s.name = Console.ReadLine();

            s.Save(s.name + "Data.csv");

        }
    }
}