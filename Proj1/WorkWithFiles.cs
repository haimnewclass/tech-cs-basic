using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    public class WorkWithFiles
    {
        public void SaveInFile()
        {
            string cont = "eredrwerwerwqerwqerwqrtwertert";
            System.IO.File.WriteAllText("sample.txt", cont);

            string newCont = System.IO.File.ReadAllText("sample.txt");
        }
        public void LoadFromCsvFile()
        {
            string newCont = System.IO.File.ReadAllText("data.csv");
            string[] item = newCont.Split(',');
            string name = item[0];
            int wins = int.Parse(item[1]);
            int loses = int.Parse(item[2]);
            int year = int.Parse(item[3]);

            wins++;

            string toFile = name + "," + wins.ToString() + "," + loses.ToString() + "," + year.ToString();

            System.IO.File.WriteAllText("data.csv", toFile);

        }
    }
}
