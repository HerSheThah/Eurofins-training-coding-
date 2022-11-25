
namespace day1
{
    struct student
    {
        public int mathsmarks;
        public int scimarks;
    }
    internal class Class1
    {
        public static void Main()
        {
            student Ram = new student();
            Ram.mathsmarks = 90;
            Ram.scimarks = 100;
            student Raja = Ram;
            Console.WriteLine("rams maths marks" + Ram.mathsmarks);
            Console.WriteLine("rams sci marks" + Ram.scimarks);
            Console.WriteLine("rajas marks" + Raja.mathsmarks);
            Console.WriteLine("rajas marks" + Raja.scimarks);
            Ram.mathsmarks = 70;
            Ram.scimarks = 80;
            Console.WriteLine("rams maths marks" + Ram.mathsmarks);
            Console.WriteLine("rams sci marks" + Ram.scimarks);
            Console.WriteLine("rajas marks" + Raja.mathsmarks);
            Console.WriteLine("rajas marks" + Raja.scimarks);

        }

    }
}