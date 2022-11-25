using System;
using System.Collections;

namespace Collections_Concepts
{

    internal class Collections
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();
            ArrayList al2 = new ArrayList();

            Console.WriteLine("enter no of persons you want");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int t = 0; t < n; t++)
            {
                ArrayList al = new ArrayList();
                Console.WriteLine("enter age and name ");
                int age = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                al.Add(age);
                al.Add(name);
                al2.Add(al);
            }


            int i = 0;
            int j = 0;
            //  al2.Add(al);
            int c = 0;
            string s = "";
            foreach (ArrayList o in al2)
            {

                for (int k = 0; k < o.Count; k++)
                {
                    // Console.WriteLine(o[k]);
                    s = s + o[k] + " ";
                }

                ht.Add(j, s);
                j++;
                s = "";
            }
            //  Console.WriteLine(c);
            //foreach (ArrayList o in al2)
            //{
            //    ht.Add(j, );
            //    j++;
            //}
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("key {0} ,   values [{1}]  ", item.Key, item.Value);
            }
        }
    }

}