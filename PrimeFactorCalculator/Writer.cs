using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class IEnumerableExtensions
    {
       public static string BuildString<T>(this IEnumerable<T> self, string delim) {
       return string.Join(",", self);        
    }
    }
    public class Writer : IWriter
    {

        public void  WritetoFile(IList<int> PrimeFactorsList)
        {

           string output= PrimeFactorsList.BuildString<int>(",");
           Console.WriteLine(output);
           Console.WriteLine("Press enter to close...");
           Console.ReadLine();


        }
    }
}
