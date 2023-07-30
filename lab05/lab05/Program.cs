using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    public class calculateValues
    {
        public double add(int n1, int n2)
        {
            return n1 + n2;
        }

        public double subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        public double div(double n1, double n2)
        {
            return n1 / n2;
        }

        public double mul(int n1, int n2)
        {
            return n1 * n2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, choice;

            calculateValues calculate = new calculateValues();

            Console.Write("Enter 1 for Addition\n" +
                "Enter 2 for Subtract\n" +
                "Enter 3 for Division\n" +
                "Enter 4 for Multiplication\n");

            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                Console.WriteLine("Addition: " + calculate.add(n1, n2));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Subtraction: " + calculate.subtract(n1, n2));
            }
            else if (choice == 3)
            {
                double d1 = Convert.ToDouble(n1);
                double d2 = Convert.ToDouble(n2);
                Console.WriteLine("Division: " + calculate.div(d1, d2));
            }
            else if (choice == 4)
            {
                Console.WriteLine("Multiplication: " + calculate.mul(n1, n2));
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }

            Console.ReadKey();
        }
    }

}
