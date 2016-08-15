using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class PrimeFactor:IPrimeFactor
    {


       public IList<int> GetPrimeFactors(int n)
        {
            var primeslist = new List<int>();
            var result = new List<int>();
            for (int div = 2; div <= n; div++)
            {
                while (n % div == 0)
                {
                    primeslist.Add(div);
                    n = n / div;
                }

            }
            return primeslist;
        }
    }
}
