using System;

namespace ForLoopString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = "Harry";
            
            for(int i = 0; i < name.Length; i++)
            {
               Console.WriteLine(name[i]);
            }

        }
    }
}
