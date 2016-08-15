using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static bool processingError
        {
            get;
            set;
        }

        static void Main(string[] args)
        {
            //if (args.Count() == 0)
            //    throw new FileNotFoundException("No  file was specified.");
            //else
            //    ProcessFile(args[0]);
            ReverseLinkedList();
           ProcessFile("C:/SBS/ASD.txt");

        }
        public static void ReverseLinkedList()
        {
            var linkedList = new LinkedList<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });


            var head = linkedList.First;
            while (head.Next != null)
            {
                var next = head.Next;
                linkedList.Remove(next);
                linkedList.AddFirst(next.Value);
            }
           var elment= linkedList.ElementAt(4);
        }

 
      public static void ProcessFile(string Filepath)
        {
            try
            {


                IPrimeFactor primefactor = new PrimeFactor();
                IReader reader = new Reader();
                IWriter writer = new Writer();

                var numberslist = reader.ReadandOutput(Filepath);
                var result = new List<int>();


                Parallel.ForEach(numberslist, x =>
                {
                    var primefactors = primefactor.GetPrimeFactors(x);
                    result.AddRange(primefactors);
                });

                writer.WritetoFile(result);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
      
        }
    }

