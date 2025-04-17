using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316.ClassPath
{
    //Способ 3________________________________________
    /*[Serializable]
    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }*/
    internal class MyException : ApplicationException
    {
        //Способ 1________________________________________
        /*private string _message;
        public DateTime TimeException { get; private set; }
        public MyException()
        {
            _message = "Моё Исключение";
            TimeException = DateTime.Now;
        }
        public override string Message
        {
            get
            {
                return _message;
            }
        }*/
        //Способ 2________________________________________
        public DateTime TimeException { get; private set; }
        public MyException() :base("Моё Исключение") 
        {
            TimeException = DateTime.Now;
        }
        
    }
}
