using MS_Testing_PracticeProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        PurchaseList purchaseList = new PurchaseList();
        SwapCompetition competition;


        [TestMethod]
        public void TestMethod1()                     //Purchase List Test Mehtod
        {
            purchaseList.ProcessPurchases("5 5 4 7 4 1 11");
            Console.WriteLine(purchaseList.UniquePrice);     
            Console.WriteLine(purchaseList.DuplicatePrice);       
        }
        [TestMethod]
        public void TestMethod2()                       //Swap Competition Test method
        {
            competition = new SwapCompetition("noon", "moon");
            Console.WriteLine(competition.IsEligibleForNextRound());     
        }

        [TestMethod]                                     //Swap Competition Test method
        public void TestMethod3()
        {
            competition = new SwapCompetition("part", "trap");
            Console.WriteLine(competition.IsEligibleForNextRound());
        }
    }
}