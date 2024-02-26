using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    class Adopted
    {
        public static void Main(string[] args)
        {
            // since this is class is not inherting from Program it cant access
            // private and protected methods
            Father p = new Father();
            p.Test3(); // public
            p.Test4(); // internal
            p.Test5(); // protected internal

        }
    }
}
