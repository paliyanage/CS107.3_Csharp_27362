// See https://aka.ms/new-console-template for more information
using Internal;
using System;
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
