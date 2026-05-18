using System;
class Parent {
    public void parentmethod() {
        Console.WriteLine("I am a Parent class");
    }
}

class Child : Parent { //This Child class inherits the Parent class
    public void childmethod()  {
        Console.WriteLine("I am a Child class");
    }
}

class DriverCode {
     static void Main() {
        Child c = new Child();
        c.childmethod();
        c.parentmethod();
    }
}
