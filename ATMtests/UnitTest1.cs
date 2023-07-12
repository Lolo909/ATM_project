using ATM_project;
using System.Linq;
using System.Windows.Forms;

namespace ATMtests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BalancedWithdrawMoney_TESTS()
        {
            Dictionary<int, int> balancedExpectedFor370 = new Dictionary<int, int>
            {
                { 100, 2 },
                { 50, 2 },
                { 20, 2 },
                { 10, 3 }
            };

            Dictionary<int, int> fromLargestToSmallestExpectedFor370 = new Dictionary<int, int>
            {
                { 100, 3 },
                { 50, 1 },
                { 20, 1 },
                { 10, 0 }
            };

            check_result(balancedExpectedFor370, 370, 1);
            check_result(fromLargestToSmallestExpectedFor370, 370, 2);
           
        }
        private void check_result(Dictionary<int, int> expected, int amount, int withdrawType)
        {
            WithdrawForm withdrawForm = new WithdrawForm();
            if(withdrawType == 1)
            {
                withdrawForm.balancedWithdrawMoney(amount);
            }else if(withdrawType == 2)
            {
                withdrawForm.fromLargestToSmallestWithdrawMoney(amount);
            }
           
            Dictionary<int, int> actual = withdrawForm.ResultFromWithdraw;

            foreach (int key in expected.Keys)
            {
                Assert.AreEqual(expected[key], actual[key], $"for key '{key}'");
            }
        }
    }
}