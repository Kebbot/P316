using System;
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
                throw new Exception("Проверка фильров исключений", de);
            }
            return result;
        }
        static void Main(string[] args)
        {
            DisponseExample de = new DisponseExample();
            de.Dispose();

            DisponseExample test = new DisponseExample();

            /*try
            {
                ExampleNameOf example = new ExampleNameOf(null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/

            /*Console.WriteLine("Введите два числа:");
            int num1, num2, result = 0;
            try
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                result = DivisionNumbers(num1, num2);
                Console.WriteLine($"Результат деления чисел: {result}");
            }
            catch (Exception e) when (e.InnerException != null) 
            {
                //дополнительная информация
                Console.WriteLine(e.Message);

                //предыдущее исключение
                Console.WriteLine(e.InnerException.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
        }
    }
}

//  = след.тема

/* Жизненный цикл объекта
 * - Выделение памяти
 * - Инициализация выделенной памяти 
 * (установка объекта в начальное значение - вызов конструктора)
 * - Использование объекта в программе
 * - Разрушение состояния объекта
 * - Освобождение занятой памяти
 */