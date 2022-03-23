using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj1OOO;

namespace Proj1
{
    class Program
    {
        static void Main(string[] args)
        {

            PracticeLesson practice = new PracticeLesson();
            practice.Ex_1();

            Bed b1 = new Bed();
            Bed b2 = new Bed();
            Bed b3 = new Bed();
            Bed b4 = new Bed();

            Table t1 = new Table();
            Table kuku = new Table();

            t1.material = "Wood";
            t1.price = 200f;


            b1.model = "Sapapa";
            b1.price = 800f;


            b2.model = "Ikea";
            b2.price = 700f;

            b3.model = "Aminach";
            b3.price = 1200f;


            Console.ReadLine();
        }
    }
}
