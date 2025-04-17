using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using P316.ClassPath;

namespace P316
{
    internal class Program
    {
        static int DivisionNumbers(int n1, int n2)
        {
            int result = 0;
            try
            {
                result = n1 / n2;
            }
            catch (DivideByZeroException de)
            {
                throw new Exception("Дополнительная информация",de);
            }
            return result; 
        }
        static void Main(string[] args)
        {

            Console.WriteLine("введите 2 числа");
            int num1, num2, result = 0;
            try
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());

                result = DivisionNumbers(num1, num2);
                Console.WriteLine($"Результат деления чисел: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //дополнительная информация

                Console.WriteLine(e.InnerException.Message);
                //предыдущее исключение
            }

            /*try
            {
                Console.WriteLine("Код исключения"); // 1
                throw new MyException();// 2

                //Эта строчка никогда не появится
                Console.WriteLine("Код исключения");
            }
            catch (MyException my)
            {
                Console.WriteLine($"Ошибка: {my.Message}");// 3
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");// 3
            }
            finally
            {
                Console.WriteLine("Код блока finally"); // 4
            }*/
            
            /*Auditory auditory = new Auditory();
            Console.WriteLine("\t\t++++++++ Список Студентов ++++++++\n");
            foreach (Student student in auditory)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("\t\t++++++++ копирование ++++++++\n");
            Student student1 = new Student
            {
                FirstName = "Gleb",
                LastName = "Ivanov",
                BirthDate = new DateTime(1999, 12, 31),
                studentCard = new StudentCard { Number = 784523, Series = "MM" }
            };
            Student student2 = (Student)student1.Clone();
            Console.WriteLine(student1);
            Console.WriteLine(student2);*/

            /*Child child1 = new Child { Name = "Arthur", Age = 12 };
            Console.WriteLine("Начальные значения:");
            Child child2 = (Child)child1.Clone();

            Console.WriteLine($"Ребенок #1: {child1}");
            Console.WriteLine($"Ребенок #2: {child2}");
            child2.Age = 14;
            Console.WriteLine($"Ребенок #1: {child1}");
            Console.WriteLine($"Ребенок #2: {child2}");*/
        }
    }
}

//checked и unchecked = след.тема

