using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Proj1OOO;


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
        

    }
}
