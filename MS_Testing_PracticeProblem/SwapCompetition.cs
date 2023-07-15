using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Testing_PracticeProblem
{
    public class SwapCompetition
    {
        private string word1;
        private string word2;

        public SwapCompetition(string word1, string word2)
        {
            this.word1 = word1;
            this.word2 = word2;
        }

        public bool IsEligibleForNextRound()
        {
            if (word1.Length != word2.Length)
                return false;

            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char c in word1)
            {
                if (letterCount.ContainsKey(c))
                {
                    letterCount[c]++;
                }
                else
                {
                    letterCount[c] = 1;
                }
            }

            foreach (char c in word2)
            {
                if (!letterCount.ContainsKey(c) || letterCount[c] == 0)
                {
                    return false;
                }
                else
                {
                    letterCount[c]--;
                }
            }
            return true;
        }
    }
}