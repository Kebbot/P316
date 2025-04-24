using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316.ClassPath
{
    internal class ExampleNameOf
    {
        public string Name { get; set; }
        public ExampleNameOf(string name)
        {
            if(name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            Name = name;
        }
    }
}
