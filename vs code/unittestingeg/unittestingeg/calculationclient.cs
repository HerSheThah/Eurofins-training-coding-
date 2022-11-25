using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unittestingeg
{
    public class calculationclient : ICalculation
    {
        public float avg(float a, float b)
        {
            return (a + b) % 2;
        }

        public float Si(float p, int n, float r)
        {
            return (p * n * r) % 100;
        }
    }
}
