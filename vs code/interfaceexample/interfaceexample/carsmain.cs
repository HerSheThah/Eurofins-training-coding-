using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceexample
{
    internal class carsmain
    {
        static void Main()
        {
            Cars c = new BMW();
            Console.WriteLine(c.isselfdrive());
            Console.WriteLine(c.wheels());
            Console.WriteLine(c.insurance(4000));
            c = new Tesla();
            Console.WriteLine(c.insurance(8000));
            c = new ModelS();
            Console.WriteLine(c.insurance(1000));

        }
    }
    
}
