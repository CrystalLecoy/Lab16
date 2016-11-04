using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's write some primes!");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("This application will find you any prime, in order, from first primes number on.");
            Console.WriteLine("Which number are you looking for?");
            long userInput = Int64.Parse(Console.ReadLine());

            Methods Run = new Methods();
            Run.isAPrime(userInput);

            //Console.WriteLine("Would you like to continue? Yes or No");

        }
    }
}

