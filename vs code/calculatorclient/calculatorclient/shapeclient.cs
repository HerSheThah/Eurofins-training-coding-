using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorclient
{
    internal class shapeclient
    {

        static void Main()
        {
            //  shapes class
            //  Shapes s = new Shapes();
            //  s.acceptDetails();
            //  s.displayDetails();

            // Rectangle class
            //Rectangle r = new Rectangle();
            //r.acceptDetails();
            //r.calculateArea();
            //r.displayDetails();

            //Circle c = new Circle();
            //c.acceptDetails();
            //c.calculateArea();
            //c.displayDetails();
            Shapes s = new Rectangle();  // dynamic polymorphism
            s.acceptDetails();  // override calls base & derived class
            s.calculateArea();
            s.displayDetails();
            s = new Circle();
            s.acceptDetails(); // new calls base class only
            s.displayDetails();
            s.calculateArea();
        }
    }
}
