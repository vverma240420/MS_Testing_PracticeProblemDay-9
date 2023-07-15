namespace MS_Testing_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string input = Console.ReadLine();

              PurchaseList purchaseList = new PurchaseList();
              purchaseList.ProcessPurchases(input);

              Console.WriteLine(purchaseList.UniquePrice != -1 ? purchaseList.UniquePrice.ToString() : "none");
              Console.WriteLine(purchaseList.DuplicatePrice != -1 ? purchaseList.DuplicatePrice.ToString() : "none");      */

            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            string word1 = words[0];
            string word2 = words[1];

            SwapCompetition competition = new SwapCompetition(word1, word2);
            bool eligible = competition.IsEligibleForNextRound();

            Console.WriteLine(eligible ? "YES" : "NO");
        }
    }
}