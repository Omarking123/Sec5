using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec5.Sealed
{
    internal class Type
    {
        class Parent
        {

        }
        class Child:Parent
        {

        }
        sealed class GrandChild : Child
        {

        }
        //class test : GrandChild { }
        
    }
}
