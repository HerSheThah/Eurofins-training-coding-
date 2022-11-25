using System;
using System.Threading.Tasks;
using System.Threading;


namespace Threads
{
    internal class Program
    {
        int a, b;
        public void add()
        {
            Console.WriteLine("Enter 2 numbers to add: ");
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            Thread.Sleep(2000);
            Console.WriteLine(a + b);
        }
        public void sub()
        {
            Console.WriteLine("Enter 2 numbers to sub: ");
            
             int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            Thread.Sleep(2000);
            Console.WriteLine(a - b);
        }

        static void main()
        {
            Program p = new Program();
            Thread t1 = new Thread(new ThreadStart(p.add));
            t1.Start();
            Thread.Sleep(2000);

            Thread t2 = new Thread(new ThreadStart(p.sub));

            t2.Start();
            Console.WriteLine("hello main program");

        }
    }
}

