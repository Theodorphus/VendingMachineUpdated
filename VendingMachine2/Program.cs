using System;
using VendingMachine2;

namespace VendingMachine2;


public class Program
{

    static void Main(string[] args)
    {


        var vendingMachine = new VendingMachine();



        Console.WriteLine("Please insert one of the amounts: (1, 5, 10, 20, 50, 100, 500, 1000)");
        vendingMachine.InsertMoney(Convert.ToInt32(Console.ReadLine()));

        while (vendingMachine.checkTotal() == true)
        {

            vendingMachine.ShowAll();

            Console.ReadLine();

        }






    }



}
