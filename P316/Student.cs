using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316
{
    public class Student
    {
        public int _studentId;
        public string _firstName="Tod";
        public string _lastName = "Govard";
        public void Print()
        {
            Console.WriteLine($"Студент: {_firstName} {_lastName}");
        }

    }
}
