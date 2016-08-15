using System.Collections.Generic;

using NUnit.Framework;
namespace ConsoleApplication1
{
    [TestFixture]
    public class PrimeFactorTests
    {
        private readonly PrimeFactor primefactor = new PrimeFactor();

        

        [Test]
        public void Test20()
        {
            Assert.AreEqual(this.primefactor.GetPrimeFactors(20), new List<int>() { 2, 2, 5 });
        }

        [Test]
        public void Test180()
        {
            Assert.AreEqual(this.primefactor.GetPrimeFactors(180), new List<int>() { 2,2,3,3,5 });
        }
    
    }
}
