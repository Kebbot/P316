using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316
{
    partial class Student
    {
        public int _studentId { get; set; }
        public int _studentId2 { get; set; }
        public string _firstName="Tod";
        public string _lastName = "Govard";
        
        public void Print()
        {
            Console.WriteLine($"Студент: {_firstName} {_lastName}");
        }

    }
}
