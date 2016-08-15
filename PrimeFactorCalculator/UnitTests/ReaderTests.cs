using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace ConsoleApplication1
{
    [TestFixture]
    public class ReaderTests
    {
    private readonly Reader reader = new Reader();
    
	[Test]
    public void TestNoFile()
    {
       var output= reader.ReadandOutput("");
       Assert.AreEqual(output.Count(), 0);
    }
    [Test]
    public void TestMissingFile()
    {
        var output = reader.ReadandOutput("C:/ASD");
        Assert.AreEqual(output.Count(), 0);
    }


    [Test]
    public void TestExistingFile()
    {
        var output = reader.ReadandOutput("C:/SBS/ASD.txt");
        Assert.AreEqual(output.Count()>0, true);
    }
    }
}
