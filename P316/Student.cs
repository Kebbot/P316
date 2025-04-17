using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316
{
    internal class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard studentCard { get; set; }

        public int CompareTo(object obj)
        {
            if(obj is Student)
            {
                return LastName.CompareTo((obj as Student).LastName);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Фамилия: {LastName} Имя: {FirstName} " +
                $"Дата рожения: {BirthDate.ToShortDateString()}";
        }
    }
}
