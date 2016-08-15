using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApplication2
{
    [TestFixture]
    public class UnitTests
    {
        SinglyLinkedList<int> linkedlistint = new SinglyLinkedList<int>();
        SinglyLinkedList<string> linkedliststring = new SinglyLinkedList<string>();

        [Test]
        public void TestInt()
        {

            linkedlistint.InsertAtFront(6);
            linkedlistint.InsertAtFront(5);
            linkedlistint.InsertAtFront(4);
            linkedlistint.InsertAtFront(3);
            linkedlistint.InsertAtFront(2);
            linkedlistint.InsertAtFront(1);
            var IntFromLast = linkedlistint.nfromlast(3);
            Assert.AreEqual(IntFromLast.Item, 4);

        }

        [Test]
        public void TestString()
        {

            linkedliststring.InsertAtFront("f");
            linkedliststring.InsertAtFront("e");
            linkedliststring.InsertAtFront("d");
            linkedliststring.InsertAtFront("c");
            linkedliststring.InsertAtFront("a");
            linkedliststring.InsertAtFront("b");
            var StringFromLast = linkedliststring.nfromlast(4);
            Assert.AreEqual(StringFromLast.Item, "c");

        }

        [Test]
        public void TestInvalid()
        {

            
            var StringFromLast = linkedliststring.nfromlast(0);
            Assert.AreEqual(StringFromLast, null);

        }
    }
}
