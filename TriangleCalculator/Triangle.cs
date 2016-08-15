using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public enum TriangleType
    {
        Error = -1, 
        Scalene = 0,
        Isosceles = 1, 
        Equilateral = 2
        
    }
    
    public class Triangle:ITriangle
    {
        private readonly IValidateValues _validatevalues;
        public Triangle(IValidateValues validatevalues)
        {
            _validatevalues = validatevalues;
        }
        public TriangleType GetTriangleType(int a, int b, int c)
        {
            int[] values = new int[3] { a, b, c };

            if (!_validatevalues.IsValidvalues(values))
                return TriangleType.Error;
            else if (_validatevalues.IsEquilateral(values))
                return TriangleType.Equilateral;
            else if (_validatevalues.IsIsosceles(values))
                return TriangleType.Isosceles;
            else if (_validatevalues.IsScalene(values))
                return TriangleType.Scalene;
            else
                return TriangleType.Error;

        }
       
       

	


}

    }

