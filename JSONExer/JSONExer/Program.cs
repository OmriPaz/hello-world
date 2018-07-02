using System;
using System.IO;

namespace JSONExer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = @"/Users/minutemedia/Documents/JSONEx.txt";
            Console.WriteLine("Insert a string");
            string var = Console.ReadLine();
            Console.WriteLine(var);
            if (!File.Exists(path)) //Checking if file exists in a path
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(var);
                }
            }
            Console.ReadKey();
        }
    }
}
