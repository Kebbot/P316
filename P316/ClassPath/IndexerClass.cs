using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316
{
    internal class IndexerClass : IIndexer
    {
        string[] _Names = new string[5];
        public string this[int index]
        {
            get { return _Names[index]; }
            set { _Names[index] = value; }
        }
        public string this[string index]
        {
            get
            {
                if (Enum.IsDefined(typeof(Number), index))
                    return _Names[(int)Enum.Parse(typeof(Number), index)];
                else
                    return "";
            }
        }
        public IndexerClass()
        {
            this[0] = "Bob";
            this[1] = "Candie";
            this[2] = "Jimmy";
            this[3] = "Joey";
            this[4] = "Nicole";

        }
    }  
}
