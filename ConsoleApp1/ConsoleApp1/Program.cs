using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = Directory.GetCurrentDirectory();
            Console.WriteLine(dir);

            string fileName = @"\post.txt";

            File.WriteAllText(dir + fileName, "Hello World!");
        }
    }
}
