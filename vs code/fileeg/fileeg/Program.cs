
using System;
using System.IO;
namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            FileStream fs = new FileStream("myfile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("ENter your name: ");
            sw.WriteLine("name" + DateTime.Now);
            sw.Flush();
            fs.Close();


        }
    }
}

