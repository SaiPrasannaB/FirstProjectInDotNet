using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            Console.WriteLine(al[0]);

            int[] i = new int[5] { 1, 2, 3, 4, 5 };
            al.AddRange(i);
            Console.WriteLine(al.Count);
        }
    }
}
