using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Programing
{
    public class Destructor
    {
        public Destructor()
        {
            Console.WriteLine("constructor");
        }
        ~Destructor()
        {
            Console.WriteLine("After Executing Programing automatically distructors are invoked: Destructor");
        }
    }
}
