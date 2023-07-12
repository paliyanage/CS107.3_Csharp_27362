using System;

class ArithmeticOperations
{
    private double operand1;
    private double operand2;

    public double Operand1
    {
        get { return operand1; }
        set { operand1 = value; }
    }

    public double Operand2
    {
        get { return operand2; }
        set { operand2 = value; }
    }

    public double Sum()
    {
        return operand1 + operand2;
    }

    public double Subtract()
    {
        return operand1 - operand2;
    }

    public double Multiply()
    {
        return operand1 * operand2;
    }

    public double Divide()
    {
        if (operand2 != 0)
            return operand1 / operand2;
        else
            throw new DivideByZeroException("Cannot divide by zero.");
    }
}