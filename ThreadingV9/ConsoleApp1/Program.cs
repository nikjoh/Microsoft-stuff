using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {

        public static List<string> myList = new List<string>();

        static void Main(string[] args)
        {
            //Thread myThread = new Thread(Run);
            //myThread.Start("Hello thread!");

            //// thread syncronization
            //lock (myList)
            //{
            //    myList.Add("lol");
            //    Monitor.PulseAll(myList);
            //}

            //app1();
            app2();
        }

        private static void app2()
        {
            Thread t = new Thread(Go);
            t.Start();
        }

        private static void Go()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("y");
            }
        }

        static void app1 ()
        {
            Thread t = new Thread(WriteY);
            t.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("x");
            }

        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("y");
            }
        }

        private static void Run(object message)
        {
            string m = (string)message;
            Console.WriteLine(m);
        }
    }
}
