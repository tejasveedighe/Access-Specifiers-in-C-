using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    internal class Aunt
    {
        public static void Main()
        {
            AccessSpecifiers.Father five = new AccessSpecifiers.Father();
            five.Test3(); // public only is accessible 
            // protected - not a child
            // private - not in same class
            // internal - not in same project
            // protected internal - if protected and internal are not accessible then protected internal cannot be accessible
        }
    }
}
