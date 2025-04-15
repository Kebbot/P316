using System;
using System.Collections.Generic;
using System.Configuration;
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
            public Laptop this[string name]
            {
                get
                {
                    if(Enum.IsDefined(typeof(Vendors), name))
                    {
                        return laptops[(int)Enum.Parse(typeof(Vendors), name)];
                    }
                    else
                    {
                        return new Laptop();
                    }
                }
                set
                {
                    if(Enum.IsDefined(typeof(Vendors), name))
                    {
                        laptops[(int)Enum.Parse(typeof(Vendors), name)] = value;
                    }
                }
            }
            public int FindByPrice(double price)
            {
                for (int i = 0; i < laptops.Length; i++)
                {
                    if (laptops[i].Price == price)
                    {
                        return i;
                    }
                }
                return -1;
            }
            public Laptop this[double price]
            {
                get
                {
                    if(FindByPrice(price) >= 0)
                    {
                        return this[FindByPrice(price)];
                    }
                    throw new Exception("Недопустимая стоимость.");
                }
                set
                {
                    if(FindByPrice(price) >= 0)
                    {
                        this[FindByPrice(price)] = value;
                    }
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
        enum Vendors {Samsung, Asus,Huawei };

    
        public interface IWorker
        {
            event EventHandler WorkEnded;
            bool IsWorking { get; }
            string Work();
        }
        public interface IManager
        {
            List<IWorker> ListOfWorkers { get; set; }
            void Organize();
            void MakeBudget();
            void Control();
        }

        abstract class Human
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public override string ToString()
            {
                return $"\nФамилия: {LastName} " +
                    $"Имя: {FirstName} Дата рождения: " +
                    $"{BirthDate.ToShortDateString()}";
            }
        }
        abstract class Employee : Human
        {
            public string Position { get; set; }
            public double Salary { get; set; }
            public override string ToString()
            {
                return base.ToString() + $"\nДолжность {Position}" +
                    $" Заработная плата: {Salary} $";
            }
        }
        class Director : Employee, IManager
        {
            public List<IWorker> ListOfWorkers { get; set; }
            public void Control()
            {
                Console.WriteLine("Контролирую работу!");
            }
            public void MakeBudget()
            {
                Console.WriteLine("Формирую бюджет!");
            }
            public void Organize()
            {
                Console.WriteLine("Организую работу!");
            }
        }
        class Seller : Employee, IWorker
        {
            bool isWorking = true;
            public bool IsWorking
            {
                get
                {
                    return isWorking;
                }
            }
            public event EventHandler WorkEnded;
            public string Work()
            {
                return "Продаю товар!";
            }
        }
        class Cashier : Employee, IWorker
        {
            public bool isWorking = true;
            public bool IsWorking
            {
                get
                {
                    return isWorking;
                }
            }
            public event EventHandler WorkEnded;
            public string Work()
            {
                return "Принимаю оплату за товар!";
            }
        }
        class Storekeeper : Employee, IWorker
        {
            public bool isWorking = true;
            public bool IsWorking
            {
                get
                {
                    return isWorking;
                }
            }
            public event EventHandler WorkEnded;
            public string Work()
            {
                return "Учитываю товар!";
            }
        }

        static void Main(string[] args)
        {
            Director director = new Director
            {
                LastName = "Doe",
                FirstName = "John",
                BirthDate = new DateTime(1998, 10, 12),
                Position = "Директор",
                Salary = 9000
            };
            IWorker seller = new Seller
            {
                LastName = "Beam",
                FirstName = "Jim",
                BirthDate = new DateTime(1956, 10, 12),
                Position = "Продавец",
                Salary = 1000
            };
            if(seller is Employee)
                Console.WriteLine($"Заработная плата продавца:" +
                    $" {(seller as Employee).Salary}");

            director.ListOfWorkers = new List<IWorker>
            { seller, new Cashier
                {
                    LastName = "Smith",
                    FirstName = "Nicole",
                    BirthDate = new DateTime(1956, 05, 23),
                    Position = "Кассир",
                    Salary = 2780
                },
                new Storekeeper 
                {
                    LastName = "Ross",
                    FirstName = "Bob",
                    BirthDate = new DateTime(1956, 05, 23),
                    Position = "Кладовшик",
                    Salary = 3000
                }
            };

            Console.WriteLine(director);
            if(director is IManager)
            {
                director.Control();
            }
            foreach (IWorker item in director.ListOfWorkers)
            {
                Console.WriteLine(item);
                if(item.IsWorking)
                {
                    Console.WriteLine(item.Work());
                }
            }

            /*Shop laptops = new Shop(3);
            laptops[0] = new Laptop { Vendor = "Samsung", Price = 520 };
            laptops[1] = new Laptop { Vendor = "Asus", Price = 500 };
            laptops[2] = new Laptop { Vendor = "Huawei", Price = 200 };
            try
            {
                for (global::System.Int32 i = 0; i < laptops.Length; i++)
                {
                    Console.WriteLine(laptops[i]);
                }
                Console.WriteLine();

                Console.WriteLine($"Производитель Asus: {laptops["Asus"]}.");
                Console.WriteLine($"Производитель MAC: {laptops["MAC"]}.");

                laptops["MAC"] = new Laptop();
                Console.WriteLine($"Стоимость 500.0: {laptops[500.0]}.");
                Console.WriteLine($"Стоимость 100500.0: {laptops[100500.0]}.");

                laptops[100500.0] = new Laptop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
        }
    }
}

//интерфейсные свойства и индексаторы = след.тема

