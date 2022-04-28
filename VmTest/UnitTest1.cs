using Xunit;
using VendingMachine2;




namespace VmTest
{


    public class VendTest
    {


        [Fact]
        public void CheckArraylength()
        {


            int[] cash = { 1, 5, 10, 20, 50, 100, 500, 1000 };


            int MoneyPool = cash.Length;


            var vm = new VendingMachine();

            Assert.Equal(8, MoneyPool);
            Assert.NotEqual(MoneyPool, vm.MoneyPool);
        }

        [Fact]
        public void CheckArray()
        {
            var vm = new VendingMachine();


            int[] cash = { 1, 5, 10, 20, 50, 100, 500, 1000 };

            Assert.Equal(1, cash[0]);
            Assert.NotEqual(1, cash[1]);
        }

        [Fact]
        public void CalculateNameContains()
        {
            var vm = new VendingMachine();


            vm.MoneyPool = 500;
            vm.cCost = 120;
            vm.currPool = 380;


            Assert.InRange<int>(vm.currPool, 380, 500);
        }

        [Fact]
        public void CalculateCurrPool()
        {
            var vm = new VendingMachine();

            vm.MoneyPool = 500;
            vm.cCost = 120;
            vm.currPool = 380;

            Assert.Equal(500 - 120, vm.currPool);
        }




    }
}