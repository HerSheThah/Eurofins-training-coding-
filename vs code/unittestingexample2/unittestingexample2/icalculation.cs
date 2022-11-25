using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unittestingexample2
{
    public interface ICalculation
    {
        float SI(float p, int n, float r);
        float avg(float a, float b);
        int sum(int a, int b);
    }
    
}
