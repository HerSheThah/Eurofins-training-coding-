using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorclient
{
    abstract internal class Shapes
    {
        public string colour { get; set; }
        protected float area; 


        public virtual void acceptDetails()
        {
            Console.WriteLine("Base class");
            Console.WriteLine("Enter colour: ");
            colour = Console.ReadLine();

        }

        public virtual void displayDetails()
        {
            Console.WriteLine("Base class");
            Console.WriteLine("Colour: " + colour);
            Console.WriteLine("Area: "+ area);
        }
        abstract public  void calculateArea();

    }

    class Rectangle: Shapes
    {
        int length, breadth;
        public override void acceptDetails()
        {
            base.acceptDetails();
            Console.WriteLine("Enter length and breadth");
            int.TryParse(Console.ReadLine(), out length);
            int.TryParse(Console.ReadLine(), out breadth);


        }

        public override void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("length: {0}", length);
            Console.WriteLine("breadth {0}",breadth);


        }
        public override void calculateArea()
        {
            area = length * breadth;
            Console.WriteLine("Area of rectangle: "+area);
        }

    }
    class Circle : Shapes
    {
        float radius;

        public new void acceptDetails()
        {
            base.acceptDetails();
            Console.WriteLine("Radius: ");
            radius = float.Parse(Console.ReadLine());   

        }
        public override void calculateArea()
        {
            area = float.Parse((3.14*radius*radius).ToString());
            Console.WriteLine("Area of the circle: ", area);
        }
        public new  void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("Radius: {0}", radius);
        }
    }
}
