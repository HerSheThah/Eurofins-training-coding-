using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class GetSet
    {
        int productid;
        string productname;

        public int Pid
        {
            get { return productid; }
            set
            {
                if (value > 0)
                    productid = value;
                else
                    productid = 0;
            }
        }
        public string pname { get; set; } // readonly property
    }

    class productclient
    {
        static void Main()
        {
            GetSet p1= new GetSet();
            
            p1.Pid = 300;
            Console.WriteLine(p1.Pid);
            p1.pname = Console.ReadLine();
            Console.WriteLine(p1.pname);

        }


    }
}
