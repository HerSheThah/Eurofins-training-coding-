using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arrayexample
{
    internal class EmpDetails
    {
        public int eid { get; set; }
        public String ename { get; set; }
        
        public EmpDetails()
        {

            eid = 404;
            ename = "NA";
        }
        public EmpDetails(int eid, string ename)
        {
            this.eid = eid;
            this.ename = ename;
        }
        public override string ToString()
        {
            return "Eid: " + eid + " Ename: " + ename;
        }
    }
}
