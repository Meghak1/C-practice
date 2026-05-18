using System;

class Parent
{
    public void Property()
    {
        Console.WriteLine("Parent Property");
    }
}

class Child1 : Parent
{
}

class Child2 : Parent
{
}

class Program
{
    static void Main()
    {
        Child1 c1 = new Child1();
        Child2 c2 = new Child2();

        c1.Property();
        c2.Property();
    }
}
