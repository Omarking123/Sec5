using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sec5.abstraction;

namespace Sec5.Partial
{
    internal partial class Employee : Parent
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int? Age { get; set; }
        partial  void DoSomeCode();
        public void Test()
        {
            DoSomeCode();
        }
    }
}
