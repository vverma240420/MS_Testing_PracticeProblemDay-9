namespace MS_Testing_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PurchaseList purchaseList = new PurchaseList();
            purchaseList.ProcessPurchases(input);

            Console.WriteLine(purchaseList.UniquePrice != -1 ? purchaseList.UniquePrice.ToString() : "none");
            Console.WriteLine(purchaseList.DuplicatePrice != -1 ? purchaseList.DuplicatePrice.ToString() : "none");
        }
    }
}