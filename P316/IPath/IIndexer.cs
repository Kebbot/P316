using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316
{
    internal interface IIndexer
    {
        string this[int index]
        {
            get;
            set;
        }
        string this[string index]
        {
            get;
        }
    }
    enum Number { one,two,three,four,five};
}
