using System;

class GrandParent
{
    public void House()
    {
        Console.WriteLine("Grandparent House");
    }
}

class Parent : GrandParent
{
    public void Car()
    {
        Console.WriteLine("Parent Car");
    }
}

class Child : Parent
{
    public void Bike()
    {
        Console.WriteLine("Child Bike");
    }
}

class Program
{
    static void Main()
    {
        Child c = new Child();

        c.House();
        c.Car();
        c.Bike();
    }
}
