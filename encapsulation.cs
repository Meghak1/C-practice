using System;
class encapsulation {
    private double balance= 5000;
     
     public double getb() {
         return balance;
     }
     
     public void setb(double amount) {
         if(amount > 0) {
             balance = amount;
         }
     }
}

class drivercode {
    public static void Main() {
        encapsulation e = new encapsulation();
        e.setb(56000.78);
        Console.WriteLine(e.getb());
    }
}
