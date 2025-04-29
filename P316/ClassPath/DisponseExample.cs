using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace P316.ClassPath
{
    internal class DisponseExample : IDisposable
    {
        //Используется для того, чтобы выяснить,
        //вызывался ли метод Dispose()
        private bool IsDisposed = false;

        private void Cleaning(bool disposing)
            //вспомогательный метод
        {
            //убедиться, что ресурсы ещё не освобождены
            if (!IsDisposed)
            {
                //Если true, то освобождаем все управляемые ресурсы
                if (disposing)
                {
                    Console.WriteLine("Освобождение управляемых ресурсов");
                }
                else
                    Console.WriteLine("Освобождение неуправляемых ресурсов");
            }
            IsDisposed = true;
        }
        public void Dispose() 
        {
            Console.WriteLine("Очистка ресурсов...");
            //вызов вспомогательного метода
            //true - очистка инициирована пользователем объекта
            Cleaning(true);

            //запретить сборщику мусора осуществлять финализацию
            GC.SuppressFinalize(this);
        }
        ~DisponseExample() 
        {
            //false - указывает на то, что очистку
            //инициировал сборщик мусора
            Cleaning(false); 
        }
        public void DoSomething()
        {
            Console.WriteLine("Выполнение Определенных операций");
        }
    }
}
