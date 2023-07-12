using System;

internal class Employee
{
    private int empid;
    private string empname;
    private string empdesignation;
    public void setval1(int ID)
    {
        empid = ID;

    }
    public void setval2(string Name)
    {
        empname = Name;
    }
    public void setval3(string Designation)
    {
        empdesignation = Designation;
    }

    public int getval1()
    {
        return empid;
    }
    public string getval2()
    {
        return empname;
    }
    public string getval3()
    {
        return empdesignation;
    }
}
