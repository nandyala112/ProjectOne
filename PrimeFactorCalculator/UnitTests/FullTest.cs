using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace ConsoleApplication1
{
    [TestFixture]
    public class FullTest
    {
        [Test]
        public void Test_End_To_End()
        {
            string Filepath = "C:/SBS/ASD.txt";
            string expected = "2,3,2,2,5,2,3,7,2,2,2,3,3,2,5,11,2,2,3,13";
            IPrimeFactor primefactor = new PrimeFactor();
            IReader reader = new Reader();
            IWriter writer = new Writer();

            var numberslist = reader.ReadandOutput(Filepath);
            var result = new List<int>();


           foreach(var x in numberslist)
           {
                var primefactors = primefactor.GetPrimeFactors(x);
                result.AddRange(primefactors);
            };

            string output= result.BuildString<int>(",");

            Assert.AreEqual(output,expected);
        }
    
    }
}
