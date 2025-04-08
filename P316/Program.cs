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

        public abstract class Figure
        {
            public abstract void Draw();
        }
        public abstract class Quadrangle : Figure
        {

        }

        public class Rectangle : Quadrangle
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public static implicit operator Rectangle(Square s)
            {
                return new Rectangle { Width = s.Length * 2, Height = s.Length };
            }
            public override void Draw()
            {
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            public override string ToString()
            {
                return $"Rectangle: Width = {Width}, Height = {Height}";
            }
        }
        public class Square : Quadrangle
        {
            public int Length { get; set; }
            public static explicit operator Square(Rectangle s)
            {
                return new Square { Length = s.Height};
            }
            //public static implicit operator Square(Rectangle number)
            //{
            //    return new Square { Length = number };
            //}

            public static explicit operator int(Square s)
            {
                return s.Length;
            }
            public static implicit operator Square(int number)
            {
                return new Square { Length = number };
            }
            public override void Draw()
            {
                for (int i = 0; i < Length; i++)
                {
                    for (int j = 0; j < Length; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            public override string ToString()
            {
                return $"Square: Length = {Length}";
            }
        }

        public class Shop
        {
            public Laptop[] laptops;
            public Shop(int size)
            {
                laptops = new Laptop[size];
            }
            public int Length
            {
                get { return laptops.Length;}
            }
            public Laptop this[int index]
            {
                get
                {
                    if (index >= 0 && index < laptops.Length)
                    {
                        return laptops[index];
                    }
                    throw new IndexOutOfRangeException();
                }
                set
                {
                    laptops[index] = value;
                }
            }

        }
        public class Laptop
        {
            public string Vendor {  get; set; }
            public double Price {  get; set; }
            public override string ToString()
            {
                return $"Vendor: {Vendor}, Price: {Price}";
            }
        }

        public class MultArray
        {
            private int[,] array;
            public int Rows { get; private set; }
            public int Cols {  get; private set; }
            public MultArray(int rows, int cols)
            {
                Rows = rows;
                Cols = cols;
                array = new int[rows, cols];
            }
            public int this[int r, int c]
            {
                get { return array[r, c]; }
                set { array[r, c] = value; }
            }
        }

        static void Main(string[] args)
        {
            MultArray[] multArray = new MultArray[2] 
            { new MultArray(2,3), new MultArray(5,5) };
            for (int i = 0; i < multArray.Length; i++)
            {
                for (int p = 0; p < multArray[i].Rows; p++)
                {
                    for (int j = 0; j < multArray[i].Cols; j++)
                    {
                        multArray[i][p, j] = p + j;
                        Console.Write($"{multArray[i][p, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            /*Shop laptops = new Shop(3);
            laptops[0] = new Laptop { Vendor = "Samsung", Price = 5200 };
            laptops[1] = new Laptop { Vendor = "Asus", Price = 4200 };
            laptops[2] = new Laptop { Vendor = "Huawei", Price = 7200 };
            try
            {
                for (int i = 0; i < laptops.Length; i++)
                {
                    Console.WriteLine(laptops[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
            /*Rectangle rectangle = new Rectangle { Width = 14, Height = 7 };
            Square square = new Square { Length = 7 };
            Rectangle rectSquare = square;

            Console.WriteLine($"Не явное преобразование квадрата ({square}) к " +
                $"прямоугольнику.\n{rectSquare}\n");
            //rectSquare.Draw();

            Square squareRect = (Square)rectangle;
            Console.WriteLine($"Явное преобразование прямоугольника ({rectangle}) к " +
                $"квадрату.\n{squareRect}\n");
            //rectSquare.Draw();

            Console.WriteLine("Введите целое число.");
            int number = int.Parse(Console.ReadLine());
            Square squareInt = number;
            Console.WriteLine($"Явное преобразование целого ({number}) к " +
                $"квадрату.\n{squareInt}\n");

            number = (int)square;
            Console.WriteLine($"Явное преобразование квадрата ({square}) к " +
               $"целому.\n{number}\n");*/
        }
    }
}
/*
 * тип_данных this[тип_аргумента] {get; set;}
 */
//перегрузка индексаторов = след.тема

