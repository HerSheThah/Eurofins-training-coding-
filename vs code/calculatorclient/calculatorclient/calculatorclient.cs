
using System;
using calculatorLogic;

namespace FirstConsoleApp
{
    internal class calculatorclient
    {
        static public Calculator calci = new Calculator();

        static void main()
        {
            int addition = calci.add(5, -5);
            Console.WriteLine(addition);    

        }

        public void averagecalc()
        {
            calci.add(5, 3);
            calci.mul(4, 2);
        }
    }
}

