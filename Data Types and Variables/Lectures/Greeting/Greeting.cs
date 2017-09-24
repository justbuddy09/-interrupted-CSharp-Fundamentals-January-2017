using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    public class Greeting
    {
        public static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            var message = string.Format($"Hello, {firstName} {lastName}. You are {age} years old.");

            Console.WriteLine(message);
        }
    }
}
