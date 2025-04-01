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
        public abstract class Human
        {
            //int _Id;
            string _firstName;
            string _lastName;
            DateTime _birthDate;
            //protected string _middleName;
            public Human() { }
            public Human(string fName, string lName)
            {
                _firstName = fName;
                _lastName = lName;
            }
            public Human(string fName, string lName, DateTime date)
            {
                _firstName = fName;
                _lastName = lName;
                _birthDate = date;
            }
            public virtual void Print()
            {
                Console.WriteLine($"Фамилия: {_lastName}\n" +
                    $"Имя: {_firstName}\n" +
                    $"Дата рождения: {_birthDate.ToShortDateString()}");
            }
            public abstract void Think();
           
        }

        public class Employee : Human
        {
            double _salary;
            //new string _middleName; // сделали сокрытие поля _middleName
            public Employee(string fName, string lName, double salary) 
                : base(fName, lName) 
            {
                _salary = salary;
            }
            public Employee(string fName, string lName) : base(fName, lName) { }
            public Employee(string fName, string lName, DateTime date, double salary)
                : base(fName,lName, date)
            {
                _salary=salary;
            }
            public override void Print()
            {
                base.Print();
                Console.WriteLine($"Заработная плата: {_salary}$");
            }
            public override void Think() { }
            
        }
    
        abstract  class Learner : Human
        {
            string _institution;
            public Learner(string fName, string lName, DateTime date,
                string institution) : base(fName, lName, date)
            {
                _institution = institution;
            }
            public abstract void Study();
            public override void Print()
            {
                base.Print();
                Console.WriteLine($"Учебное заведение: {_institution}");
            }
        }

        class Student : Learner
        {
            string _groupName;
            public Student(string fName, string lName,
                DateTime date, string institution, string groupName) :
                base(fName,lName,date,institution)
            {
                _groupName = groupName;
            }
            public override void Think()
            {
                Console.WriteLine("Я думаю как студент.");
            }
            public override void Study()
            {
                Console.WriteLine("Я изучаю предметы в интституте");
            }
            public override void Print()
            {
                base.Print();
                Console.WriteLine($"Учусь в {_groupName} группе.");
            }
        }

        class ShoolChild : Learner
        {
            string _className;
            public ShoolChild(string fName, string lName,
                DateTime date, string institution,string className) :
                base(fName, lName, date, institution)
            {
                _className = className;
            }
            public override void Think()
            {
                Console.WriteLine("Я думаю как школьник.");
            }
            public override void Study()
            {
                Console.WriteLine("Я изучаю предметы в школе.");
            }
            public override void Print()
            {
                base.Print();
                Console.WriteLine($"Учусь в {_className} классе.");
            }
        }


        static void Main(string[] args)
        {
            Learner[] learners =
            {
                new Student("John", "Doe",
                new DateTime(1999,6,12), "IT Step", "P316"),
                new ShoolChild("Jack", "Smith",
                new DateTime(2008,4,18), "Shool#154", "1-A")
            };
            foreach (Learner item in learners)
            {
                item.Print();
                item.Think();
                item.Study();
                Console.WriteLine();
            }
           
        }

    }
}

//Полиморфизм C# 
//абстрактный класс