using System;
using System.Collections;
using System.Reflection;

using P316.IPath;


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
                throw new Exception("Проверка фильров исключений", de);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Auditory auditory = new Auditory();
            Console.WriteLine("++++++ Список студентов ++++++\n");
            foreach (Student student in auditory)
            {
                Console.WriteLine(student);
            }


            /*Point2D<int> p1 = new Point2D<int>();
            Console.WriteLine($"x = {p1.X} y = {p1.Y}");

            Point2D<double> p2 = new Point2D<double>(10.5,20.3);
            Console.WriteLine($"NX = {p2.X} y = {p2.Y}");
            Console.WriteLine(typeof(Point2D<double>));*/

            /*ArrayList arrayList = new ArrayList();
            arrayList.Add(10); // помещаем в коллекцию элемент типа int
            try
            {
                //при извлечении выполняем приведение к типу short
                //из-за ошибочного указания типа возникает исключение
                short a = (short)arrayList[0];
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            object obj = 45; //boxing
            Console.WriteLine($"Упаковка: {obj}");

            int number = (int)obj; //unboxing
            Console.WriteLine($"Распаковка: {number}");*/

            /*Queue queue = new Queue();
            Console.Write("Метод Push(): ");
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("three");
            foreach (string item in queue)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine($"\nМетод Dequeue(): {queue.Dequeue()}");
            Console.WriteLine($"\nСуществует ли элемент \"three\": {queue.Contains("three")}\n");
            Console.WriteLine($"\nМетод Peek(): {queue.Peek()}\n");*/

            /*Stack stack = new Stack();
            Console.Write("Метод Push(): ");
            stack.Push("One");
            stack.Push("Two");
            stack.Push("three");
            foreach (string item in stack)
            {
                Console.Write($"{item}, ");
            }*/

            /*ArrayList arrayList1 = new ArrayList(); //Вместимость по умолчанию
            Console.WriteLine($"Вместимость по умолчанию: {arrayList1.Capacity}");

            arrayList1.Add("One");
            Console.WriteLine($"Вместимость после добавления коллекции: {arrayList1.Capacity}");

            arrayList1.AddRange(new int[] {2,5,48,14});
            Console.WriteLine($"Вместимость после обновления коллекции: {arrayList1.Capacity}");

            arrayList1.Capacity = 10;
            Console.WriteLine($"Вместимость задана через свойство: {arrayList1.Capacity}");

            Console.WriteLine($"Фактическое количество элементов: {arrayList1.Count}");

            arrayList1.TrimToSize();
            Console.WriteLine($"Вместимость уменьшена до реального количества элементов: {arrayList1.Capacity}");

            Console.WriteLine($"Элемент с индексом 2: {arrayList1[2]}");
            Console.WriteLine("Все элементы коллекции:");
            foreach (object item in arrayList1)
            {
                Console.WriteLine($"\t{item}");
            }*/

            /*using (DisponseExample test = new DisponseExample())
            {
                test.DoSomething();
            }*/

        }
    }
}

// 9 урок = след.тема

