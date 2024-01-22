using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_7_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //use write not writeline 
            Console.Write("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Hi" +  name);
            Console.Write("How old are you? ");
            //the values from user are always string
            string age = Console.ReadLine();
            Console.WriteLine("you are " + age);

            Console.ReadLine();

        }
    }
}
