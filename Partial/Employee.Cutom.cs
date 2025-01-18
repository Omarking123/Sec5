using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sec5.abstraction;

namespace Sec5.Partial
{
    internal partial class Employee:Parent
    {
        public string? Address { get; set; }

        public  void DoSomeCode(int X)
        {
            int x = 10;
            x++;
            Console.WriteLine(x);
        }
    }
}
