using System;

class MathOperation
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        MathOperation m = new MathOperation();

        Console.WriteLine(m.Add(10,20));
        Console.WriteLine(m.Add(2.5,3.5));
    }
}
