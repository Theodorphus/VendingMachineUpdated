using System;
namespace VendingMachine;

 class Pepsi : Product
{

    public override void Examine()
    {
        Console.WriteLine("\nThis is a " + Name + " And it costs " + Price + "kr");
    }

    public override void Use()
    {
        Console.WriteLine("\n" + Name + " is used by opening the lid and drinking it");
    }

}