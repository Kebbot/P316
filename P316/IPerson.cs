using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316
{
    internal interface IPerson
    {
        string Last_Name { get; set; }
        int Age { get;}
        string Gender { get;}
    }
}
