using MS_Testing_PracticeProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        PurchaseList purchaseList = new PurchaseList();
        [TestMethod]
        public void TestMethod1()
        {
            purchaseList.ProcessPurchases("5 5 4 7 4 1 11");
            Console.WriteLine(purchaseList.UniquePrice);     
            Console.WriteLine(purchaseList.DuplicatePrice);
        }
    }
}