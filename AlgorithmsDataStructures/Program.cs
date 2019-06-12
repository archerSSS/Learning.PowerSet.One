using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
    public class Program
    {
        public static void Main(String[] args)
        {


            HashSet<string> hash = new HashSet<string>();
            HashSet<int> hash1 = new HashSet<int>();
            hash.Add("");
            hash.Add("");
            hash.Add(null);

            bool b = hash.Contains(null);
            bool b1 = hash1.Contains(0);

            HomeBit hob = new HomeBit(10);

            int g = hob.GetValue();
        }
    }
}
