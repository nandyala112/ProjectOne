using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IValidateValues
    {

        bool IsScalene(int[] values);
        bool IsIsosceles(int[] values);
        bool IsEquilateral(int[] values);
        bool IsValidvalues(int[] values);
    }
}
