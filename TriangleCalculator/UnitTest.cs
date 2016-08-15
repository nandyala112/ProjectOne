using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace ClassLibrary1
{
[TestFixture]
    public  class UnitTest
    {

    private readonly ValidateValues validate = new ValidateValues();

  [Test]
    public void TestIsosceles()
    {
     
       int[] arr1 = new int[] { 3, 3, 5 };
       Assert.AreEqual(validate.IsIsosceles(arr1),true);

    }
    [Test]
     public void TestEquilateral()
    {
         int[] arr1 = new int[] { 3, 3, 3 };
         Assert.AreEqual(validate.IsEquilateral(arr1), true);

    }
    [Test]
     public void TestScalene()
    {int[] arr1 = new int[] { 3, 4, 5 };
    Assert.AreEqual(validate.IsScalene(arr1), true);

    }
    [Test]
    public void TestInvalid()
    {int[] arr1 = new int[] { -3, 4, 5 };
    Assert.AreEqual(validate.IsValidvalues(arr1), false);

    }


}
}
