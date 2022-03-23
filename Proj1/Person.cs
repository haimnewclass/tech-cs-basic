using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Proj1OOO;
using System.IO;

namespace Proj1
{
    public class Person
    {
        public Proj1OOO.Table tbl;
        public int id;
        public string name;
        public string address;
        public bool merried=false;
        protected DateTime merriedDate;

        public Person(string fileName)
        {
            if(File.Exists(fileName))
            {
                Load(fileName);
            }
        }

        public bool Devorce()
        {            
            bool ret;

            if (!merried)
                ret = false;
            else
            {
                merried = false;
                ret = true;
            }

            return ret;
        }
        public bool CommitMerried(DateTime whenMerried)
        {
            bool ret;

            if (merried)
                ret = false;
            else
            {
                merried = true;
                merriedDate = whenMerried;
                ret = true;
            }
            return ret;
        }
        
        public void Save(string fileName)
        {
            string str = name + "," + id.ToString() + "," + merried.ToString();
            System.IO.File.WriteAllText(fileName, str);
        }

        public void Load(string fileName)
        {
            string dataFromFile = System.IO.File.ReadAllText(fileName);
            string[] details = dataFromFile.Split(',');
            this.name = details[0];
            this.id = int.Parse(details[1]);
            this.merried = bool.Parse(details[2]);
        }
    }
}
