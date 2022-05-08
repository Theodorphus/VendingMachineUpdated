using System;
using VendingMachine;

namespace VendingMachine;


public class Program
{

    static void Main(string[] args)
    {


        var vendingMachine = new VendingMachine();



        Console.WriteLine("Please insert one of the amounts: (1, 5, 10, 20, 50, 100, 500, 1000)");
        vendingMachine.InsertMoney(Convert.ToInt32(Console.ReadLine()));

        while (vendingMachine.checkTotal() == true)
        {


            try
            {
                vendingMachine.ShowAll();

                Console.ReadLine();
            }

            catch (FormatException ex)

            {


                Console.WriteLine(ex +  " Try again with a correct input");
            }

           
        }


        vendingMachine.Log();
    }



    }




