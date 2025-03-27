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
        public class Human
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
        }

        public sealed class Tutor : Human { }

        class Manager : Employee
        {
            string _fieldActivity;
            public Manager(
                string fName, string lName, DateTime date, double salary, string activity)
                : base(fName,lName,date,salary)
            {
                _fieldActivity = activity;
            }
            public override void Print()
            {
                base.Print();
                Console.WriteLine($"Менеджер. Сфера деятельности: {_fieldActivity}");
            }
        }
        class Scientist : Employee
        {
            string _scientificDirection;
            public Scientist(
                string fName, string lName, DateTime date, double salary, string direction)
                : base(fName,lName,date,salary)
            {
                _scientificDirection = direction;
            }
            public override void Print()
            {
                base.Print();
                Console.WriteLine($"Ученый. Научное направлени: {_scientificDirection}");
            }
        }
        class Specialist : Employee
        {
            string _qualification;
            public Specialist(
                string fName, string lName, DateTime date, double salary, string qualification)
                : base(fName,lName,date,salary)
            {
                _qualification = qualification;
            }
         
            public override void Print()
            {
                base.Print();
                Console.WriteLine($"Специалист. Квалификация: {_qualification}");
            }
        }

        static void Main(string[] args)
        {
            /*Employee manager =
                new Manager("Tim", "Doe", new DateTime(1995, 7, 23), 3500, "Продукты питания");

            Employee[] employees = {
                manager,
                new Scientist("Jim","Beam",
                new DateTime(1956,3,15),4253,"История"),
                new Specialist("Jack", "Smith",
                new DateTime (1996,11,5), 2587.43,"Физика")
            };
            foreach (Employee item in employees)
            {
                item.Print();
                try
                {
                    ((Specialist)item).ShowSpecialist(); //способ 1
                    Console.WriteLine();
                }
                catch {}

                Scientist scientist = item as Scientist; // способ 2
                if(scientist != null)
                {
                    scientist.ShowScientist();
                    Console.WriteLine();
                }

                if (item is Manager)
                {
                    (item as Manager).ShowManager(); // способ 3
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();*/

            Human employee = 
                new Manager("Борис", "Бритва", DateTime.Now, 3587.44, "Продукты питания");
            employee.Print();


        }

    }
}

//Полиморфизм C# 
//абстрактный класс