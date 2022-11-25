using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threadseg
{
    internal class threadex
    {

        static void Main()
        {

            callmethod();
            Console.ReadKey();
        }

        public static async void callmethod()
        {
            Task<int> task = method1();
            method2();
            int count = await task;
            method3(count);
        }

        public static async Task<int> method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("method 1");
                    count += 1;
                }
            });
            return count;
        }

        public static void method2()
        {
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("method 2: ");

            }
        }
        public static void method3(int count)
        {
            Console.WriteLine(count);

        }

    }
}
