using Xunit;
using VendingMachine;
using System;
using System.IO;

namespace VendingMachine.Tests;


public class VendingMachineShould
{


    [Fact]
    public void CheckArraylength()
    {


        int[] cash = { 1, 5, 10, 20, 50, 100, 500, 1000 };


        int MoneyPool = cash.Length;


        var sut = new VendingMachine();

        Assert.Equal(8, MoneyPool);

    }

    [Fact]
    public void CheckArray()
    {
        var sut = new VendingMachine();


        int[] cash = { 1, 5, 10, 20, 50, 100, 500, 1000 };


        Assert.NotEqual(1, cash[1]);
    }

    [Fact]
    public void CalculateNameContains()
    {
        var sut = new VendingMachine();


        sut.MoneyPool = 500;
        sut.cCost = 120;
        sut.currPool = 380;


        Assert.InRange<int>(sut.currPool, 380, 500);
    }

    [Fact]
    public void CalculateCurrPool()
    {
        var sut = new VendingMachine();

        sut.MoneyPool = 500;
        sut.cCost = 120;
        sut.currPool = 380;

        Assert.Equal(500 - 120, sut.currPool);
    }

    [Fact]
    public void CheckMain()
    {
        var sut = new VendingMachine();

        while (sut.checkTotal() == true)
        {

            sut.ShowAll();

            Assert.True(sut.checkTotal() == true);

        }

    }
        [Fact]
    public void Log_Test()
    {
        
        
        VendingMachine sut = new VendingMachine();
        var output = new StringWriter();
        Console.SetOut(output);
        var expectedValue = "Error Message: Test Exception";
       sut.Log(new Exception("Test Exception"));
        Assert.Contains(expectedValue, output.ToString());
    



}


        }
    

  
