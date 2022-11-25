
using System;
using System.Collections;
namespace arrayexample
{
    internal class ArrayExample
    {
        static void Main()
        {
            #region
            //ArrayList ar = new ArrayList();
            //ar.Add(true);
            //ar.Add(3.14);
            //ar.Add(21);
            //ar.Add("hello harshi");

            //foreach (var item in ar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            // hashtables 
            Hashtable ht = new Hashtable();
            ht.Add(1003, new EmpDetails(2, "joey"));
            ht.Add(1005, new EmpDetails(3, "phoebe"));
            ht.Add(1001, new EmpDetails(7, "rachel"));

            ht = { {10, [19, "harshi"]}, { } }
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine("Reno: " + item.Key +" "+ item.Value.ToString());
                
            }
            Hashtable studata = new Hashtable();
            for(int i=10; i < 12; i++)
            {

                Console.WriteLine("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();

                ArrayList stude = new ArrayList();
                stude.Add(age);
                stude.Add(name);
                int t = age;
                string s = t.ToString() + name;
                

                // { 10, [19, "harshi"]}
               
            }
            
            foreach(DictionaryEntry ele in studata)
            {
                Console.WriteLine("key: " + ele.Key);
                Console.WriteLine("age and name: ");
                foreach(var v in ele.Value)
                {
                    Console.WriteLine(ele.Value);
                }
                
                
                
            }





           




        }
    }
}

