using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    // Consuming from same project from a child class
    // default class is internal
    class Child : Father
    {
        public static void Main(string[] args)
        {
            // as a sub class of program Child1 can access all except the private method Test1
            Child a = new Child();
            a.Test2(); // protected
            a.Test3(); // public
            a.Test4(); // internal
            a.Test5(); // protected internal
        }
    }
}
