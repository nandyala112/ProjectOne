using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Reader:IReader
    {

        public IList<int> ReadandOutput(string path)
        {
           
            var list = new List<int>();
            if (path == "" || !File.Exists(path))
                return list;

            using (var streamReader = new StreamReader(path))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(int.Parse(line));
                }
            }
            return list;
        }
    }
}
