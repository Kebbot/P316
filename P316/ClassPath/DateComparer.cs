using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316
{
    internal class DateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if(x is Student && y is Student)
                return DateTime.Compare((x as Student).BirthDate,
                    (y as Student).BirthDate);

            throw new NotImplementedException();
        }
    }
}
