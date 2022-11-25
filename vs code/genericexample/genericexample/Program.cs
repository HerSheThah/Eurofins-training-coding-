
using System;
using System.Collections.Generic;
namespace genericexample
{
    internal class Program
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee(12, "jesi", 12000));
            list.Add(new Employee(15, "johnathan", 15000));
            list.Add(new Employee(19, "jeni", 18000));

            Dictionary<string, Employee> dict = new Dictionary<string, Employee>();
            dict.Add("abc", new Employee(13, "jahan", 12000));
            dict.Add("cde", new Employee(14, "jahan", 12000));
            foreach(KeyValuePair<string, Employee> item in dict)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.ename);
            }


        }
    }
}

