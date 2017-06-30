using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2];
            int result = 0;
            string operation = "";
            string exit = "";

            Console.WriteLine("Basic Calculator");
            Console.WriteLine("Operations available: +, -, *, /");
            
            while (exit != "No")
            {

            
            Console.WriteLine("Enter Number: ");
            arr[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Operation: ");
            operation = Console.ReadLine();

            Console.WriteLine("Enter 2nd number: ");
            arr[1] = Convert.ToInt32(Console.ReadLine());

            if (operation == "+")
            {
                result = arr[0] + arr[1];
            }

            else if (operation == "-")
            {
                result = arr[0] - arr[1];
            }

            else if (operation == "*")
            {
                result = arr[0] * arr[1];
            }

            else if (operation == "/")
            {
                result = arr[0] / arr[1];
            }

            else
            {
                Console.WriteLine("This is not supported");
            }

            Console.WriteLine("Result: " + result);
            Console.WriteLine("Continue? Yes or No.");
            exit = Console.ReadLine();

            }
            Console.Read();
            
        }
    }
}
