using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceexample
{
    internal interface Cars
    {
        int wheels();
        string type();
        bool isselfdrive();
        float insurance(float additionalcost);
    }


    internal class BMW : Cars
    {
        public float insurance(float additionalcost)
        {
            return 100000 + additionalcost;
        }

        public bool isselfdrive()
        {
            return true;
        }

        public string type()
        {
            return "SUV";
        }

        public int wheels()
        {
            return 6;
        }
    }

    internal class Tesla : Cars
    {
        protected float baseinsure = 200000;
        public virtual float insurance(float additionalcost)
        {
            return baseinsure+additionalcost;
        }

        public bool isselfdrive()
        {
            return true;
        }

        public string type()
        {
            return "Supercharger";
        }

        public int wheels()
        {
            return 8;
        }
    }

    internal class ModelS: Tesla
    {
        public override float insurance(float amt)
        {
            float bamt = base.insurance(amt);
            float manufamt = 5000;
            return manufamt+bamt;
        }
    }
}
