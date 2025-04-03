using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace P316
{
    internal class Program
    {
        
        public class Point
        {
            public int X {  get; set; }
            public int Y {  get; set; }
            //Перегрузка инкремента (++)
            public static Point operator ++(Point s)
            {
                s.X++;
                s.Y++;
                return s;
            }
            //Перегрузка декремента (--)
            public static Point operator --(Point s)
            {
                s.X--;
                s.Y--;
                return s;
            }
            //Перегрузка оператора (- унарный) 
            public static Point operator -(Point s)
            {
                return new Point { X = -s.X, Y = -s.Y };
            }
            public override string ToString()
            {
                return $"Point: X = {X}, Y = {Y}";
            }
            public override bool Equals(object obj)
            {
                return this.ToString() == obj.ToString();
            }
            public override int GetHashCode()
            {
                return this.ToString().GetHashCode();
            }
            public static bool operator ==(Point p1,Point p2)
            {
                return p1.Equals(p2);
            }
            public static bool operator !=(Point p1, Point p2)
            {
                return !(p1 == p2);
            }
            public static bool operator >(Point p1,Point p2)
            {
                return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) >
                    Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
            }
            public static bool operator <(Point p1, Point p2)
            {
                return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) <
                    Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
            }
            public static bool operator true(Point p)
            {
                return p.X != 0 || p.Y != 0 ? true : false;
            }
            public static bool operator false(Point p)
            {
                return p.X == 0 && p.Y == 0 ? true : false;
            }
        }
        public class Vector
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Vector() { }
            public Vector(Point begin, Point end)
            {
                X = end.X - begin.X;
                Y = end.Y - begin.Y;
            }
            public static Vector operator +(Vector v1, Vector v2)
            {
                return new Vector { X = v1.X + v2.X, Y = v1.Y + v2.Y };
            }
            public static Vector operator -(Vector v1, Vector v2)
            {
                return new Vector { X = v1.X - v2.X, Y = v1.Y - v2.Y };
            }
            public static Vector operator *(Vector v, int n)
            {
                v.X *= n;
                v.Y *= n;
                return v;
            }
            public override string ToString()
            {
                return $"Vector: X = {X}, Y = {Y}";
            }
        }

        public class CPoint
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        struct SPoint
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        static void Main(string[] args)
        {

            Point point = new Point
            {
                X = int.Parse(Console.ReadLine()),
                Y = int.Parse(Console.ReadLine())
            };
            if (point)
                Console.WriteLine("Точка не в начале координат");
            else
                Console.WriteLine("Точка в начале координат");

            /*Point point1 = new Point {X = 20,Y=20 };
            Point point2 = new Point { X = 20,Y = 20};

            Console.WriteLine($"point1: {point1}");
            Console.WriteLine($"point2: {point2}\n");
            Console.WriteLine($"point1 == point2: {point1 == point2}");
            Console.WriteLine($"point1 != point2: {point1 != point2}");
            Console.WriteLine($"point1 > point2: {point1 > point2}");
            Console.WriteLine($"point1 < point2: {point1 < point2}");*/
                /*
                //Ссылочный тип
                CPoint cp = new CPoint { X = 10, Y = 10 };
                CPoint cp1 = new CPoint { X = 10,Y = 10 };
                CPoint cp2 = cp1;

                Console.WriteLine($"ReferenceEquals(cp,cp1) = " +
                    $"{ReferenceEquals(cp, cp1)}");

                Console.WriteLine($"ReferenceEquals(cp1,cp2) = " +
                    $"{ReferenceEquals(cp1, cp2)}");

                Console.WriteLine($"Equals(cp,cp1) = " +
                    $"{Equals(cp, cp1)}");

                //Значимый тип
                SPoint sp = new SPoint { X = 10, Y = 10 };
                SPoint sp1 = new SPoint { X = 10,Y= 10 };

                Console.WriteLine($"Equals(sp,sp1) = " +
                    $"{Equals(sp, sp1)}");*/

                /*Point p1 = new Point {X=2,Y=3 };
                Point p2 = new Point { X = 3, Y = 1 };
                Vector v1 = new Vector(p1, p2);
                Vector v2 = new Vector {X = 2,Y=3 };

                Console.WriteLine($"\tВектора\n{v1}\n{v2}");
                Console.WriteLine($"\n\tСложение векторов\n{v1 + v2}\n");
                Console.WriteLine($"\n\tРазность векторов\n{v1 - v2}\n");
                Console.WriteLine("Введите целое число:");
                int n = int.Parse( Console.ReadLine() );
                v1 *= n;
                Console.WriteLine($"\n\tУмножение вектора на число {n}\n {v1}\n");*/
        }

    }
}

//Перегрузка Логических операторов = след.тема

/*
 * public static тип_возврата operator символ_операции(параметры)
 * { тело перегрузки }
 */