﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your employee id: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            string Name = Console.ReadLine();


            Console.WriteLine("Enter Employee Designation: ");
            string Designation = Console.ReadLine();

            Employee empobj = new Employee();

            empobj.setval1(ID);
            empobj.setval2(Name);
            empobj.setval3(Designation);
            Console.Write("Hello " + empobj.getval2() + " - your ID is " + empobj.getval1() + ". You are a " + empobj.getval3());
            Console.ReadKey();

        }

    }
}
