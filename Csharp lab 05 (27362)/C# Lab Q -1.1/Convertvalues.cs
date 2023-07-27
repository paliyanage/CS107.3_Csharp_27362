using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lab_Q__1._1
{
     public  class Convertvalues
    {
        public void kilometerTometer()
        {
            Console.WriteLine("Enter the value in kilometers:");
            double kilometers = ConvertTodouble("Console.ReadLine());
                double meters = kilometers * 1000;
            Console.WriteLine("The equivalent value in meters:" + meters);

        }
    }
}
