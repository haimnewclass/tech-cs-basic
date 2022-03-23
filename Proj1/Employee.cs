using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    public class Employee:Person
    {
        public bool HasCar;
        public int Sallary;
        public int WorkId;

        public Employee(int workId)
        {
            WorkId = workId;
        }
        public Employee(int workId,bool hasCar)
        {
            WorkId = workId;
            HasCar = hasCar;
        }
        public int AddBonusToSallary()
        {
            DateTime d1 = merriedDate;

                        
            if (merried)
            {
                Sallary += 1000;
            }

            return Sallary;
        }
    }
}
