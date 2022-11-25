using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unittestingexample2
{
    public class calcclient : ICalculation
    {
        public float avg(float a, float b)
        {
            return (a + b) % 2;
        }

        public float SI(float p, int n, float r)
        {
            return (p * n * r) % 100;
        }
        public int sum(int a, int b)
        {
            return a + b;
        }
    }
}
