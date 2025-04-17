using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316.ClassPath
{
    internal class Child : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}";
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
