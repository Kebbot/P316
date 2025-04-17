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

namespace P316
{
    internal class Program
    {
        /*interface IA
        {
            void Show();
        }
        interface IB
        {
            void Show();
        }
        interface IC
        {
            void Show();
        }
        class InherInterface : IA, IB, IC
        {
            void IA.Show()
            {
                Console.WriteLine("interface IA");
            }
            void IB.Show()
            {
                Console.WriteLine("interface IB");
            }
            public void Show()
            {
                Console.WriteLine("interface IC");
            }
        }*/


        static void Main(string[] args)
        {
            Auditory auditory = new Auditory();
            Console.WriteLine("\n\t\t++++++ Список студентов ++++++\n");
            auditory.Sort();
            foreach (Student student in auditory)
            {
                Console.WriteLine(student);
            }

            /*InherInterface er = new InherInterface();
            er.Show(); //вызов метода интерфейса IC неявно 

            ((IA)er).Show();//вызов метода интерфейса IA неявно 

            IB iB = new InherInterface();
            iB.Show(); ////вызов метода интерфейса IB неявно */

            /*IndexerClass indexerClass = new IndexerClass();
            Console.WriteLine("\t\tВывод значений\n");
            Console.WriteLine("Использование индексатора" +
                " с целочисленным параметром: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(indexerClass[i]);
            }
            Console.WriteLine("\nИспользование индексатора" +
                " со строковым параметром: ");
            string[] ArrNums = { "one", "two", "three", "four", "five" };
            foreach (var item in ArrNums)
            {
                Console.WriteLine(indexerClass[item]);
            }*/
        }
    }
}

// = след.тема

