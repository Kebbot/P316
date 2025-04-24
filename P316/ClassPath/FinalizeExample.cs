using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316.ClassPath
{
    internal class FinalizeExample
    {
        //protected override void Finalize() { }
        ~FinalizeExample() { }
    }
}
