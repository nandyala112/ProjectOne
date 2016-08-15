using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ValidateValues :IValidateValues
    {

        public bool IsValidvalues(int[] values)
        {
            return values.All(x => x > 0);
        }
        public bool IsScalene(int[] values)
        {
            return values.Distinct().Count() == 3;
        }

        public bool IsIsosceles(int[] values)
        {
            return values.Distinct().Count() == 2;
        }

        public bool IsEquilateral(int[] values)
        {
            return values.Distinct().Count() == 1;
        }

    
    
    }
}
