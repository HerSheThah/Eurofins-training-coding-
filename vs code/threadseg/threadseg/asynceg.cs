using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threadseg
{
    class AsynAwait
    {
        public async Task<string> mymethod()
        {
            await Task.Delay(2000);
            return "completed";
        }

        static void main()
        {
            AsynAwait obj = new AsynAwait();
            var res= obj.mymethod().Result;
            Console.WriteLine(res);
        }
    }
}
