using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316
{
    internal class Program
    {
        struct Dimensions
        {
            private double Length;
            private double Width;
            public List<string> strings;

            public Dimensions(double length, double width)
            {
                strings = new List<string>();
                Length = length;
                Width = width;
            }
            public void Print()
            {
                Console.WriteLine($"Длинна: {Length}, ширина: {Width}.");
            }
        }

        class MyClass
        {
            public readonly int var = 10;
            public readonly int[] myArr = {1,2,3 };
        }

        private static void MyFunction(ref int i, ref int[] myArr)
        {
            Console.WriteLine("Внутри функции MyFunction до изменения i = " + i);
            Console.Write("myArr { ");
            foreach (int val in myArr)
                Console.Write(val + " ");
            Console.WriteLine(" }");

            i = 100;
            myArr = new int[] {3,2,1};
            Console.WriteLine("Внутри функции MyFunction после изменения i = " + i);
            Console.Write("myArr { ");
            foreach (int val in myArr)
                Console.Write(val + " ");
            Console.WriteLine(" }");
        }

        static void Main(string[] args)
        {
            //int i = 10;
            //int[] myArr = { 1, 2, 3 };
            //Console.WriteLine("Внутри метода Main до передачи в метод" +
            //    " MyFunction i = " + i);
            //Console.Write("myArr { ");
            //foreach (int val in myArr)
            //    Console.Write(val + " ");
            //Console.WriteLine(" }");

            //MyFunction(ref i, ref myArr);

            //Console.WriteLine("Внутри метода Main после передачи в метод" +
            //   " MyFunction i = " + i);
            //Console.Write("myArr { ");
            //foreach (int val in myArr)
            //    Console.Write(val + " ");
            //Console.WriteLine(" }");

            int i;
            GetDigit(out i);
            Console.WriteLine($"i = {i}");

        }

        private static void GetDigit(out int digit)
        {
            digit = new Random().Next(10);
        }
       
    }
}

