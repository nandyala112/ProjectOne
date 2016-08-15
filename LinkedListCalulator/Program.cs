using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
    
    public static void Main(string[] args)
   {
       SinglyLinkedList<int> linkedlistint = new SinglyLinkedList<int>();
       linkedlistint.InsertAtFront(6);
       linkedlistint.InsertAtFront(5);
       linkedlistint.InsertAtFront(4);
       linkedlistint.InsertAtFront(3);
       linkedlistint.InsertAtFront(2);
       linkedlistint.InsertAtFront(1);
       var IntFromLast = linkedlistint.nfromlast(3);

       SinglyLinkedList<string> linkedliststring = new SinglyLinkedList<string>();
       linkedliststring.InsertAtFront("f");
       linkedliststring.InsertAtFront("e");
       linkedliststring.InsertAtFront("d");
       linkedliststring.InsertAtFront("c");
       linkedliststring.InsertAtFront("a");
       linkedliststring.InsertAtFront("b");
       var StringFromLast = linkedliststring.nfromlast(3);
        

    }
   }
    
    }
