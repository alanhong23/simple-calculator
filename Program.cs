using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            { 

                Console.Write("Enter your first number: ");
                double first_number = Convert.ToDouble(Console.ReadLine());
            
                Console.Write("Enter your operator: ");
                string op = Console.ReadLine();

                Console.Write("Enter your second number: ");
                double second_number = Convert.ToDouble(Console.ReadLine());

                Console.Write("\n{0}{1}{2} = ", first_number, op, second_number);

            
                switch (op)
                {
                    case "+":
                        Console.Write(first_number + second_number);
                        break;

                    case "-":
                        Console.Write(first_number - second_number);
                        break;

                    case "/":
                        Console.Write(first_number / second_number);
                        break;

                    case "*":
                        Console.Write(first_number * second_number);
                        break;

                    default:
                        Console.WriteLine("invalid operator");
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Keep();
        }

        static void Keep()
        {
            Console.Write("\n\nEnter to close the window...");
            Console.ReadLine();
        }
    }
}
