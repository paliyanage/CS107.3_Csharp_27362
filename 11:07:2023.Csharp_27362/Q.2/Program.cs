using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main()
        {
            ArithmeticOperations calculator = new ArithmeticOperations();
            calculator.Operand1 = 8;
            calculator.Operand2 = 2;

            double sum = calculator.Sum();
            double difference = calculator.Subtract();
            double product = calculator.Multiply();
            double quotient = calculator.Divide();

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
        }
    }
}
