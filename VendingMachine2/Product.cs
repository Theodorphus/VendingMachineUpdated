using System;
namespace VendingMachine;
abstract class Product
{
    public string? Name { get; set; }
    public int Price { get; set; }

    public abstract void Examine();
    public abstract void Use();


}
