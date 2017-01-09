using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Function
    {
        string namesCombined;
        
        public Function()
        {
             namesCombined = "tonjackieidoharlemayson";
        }
        public void CountLetters()
        {
            for (int i = 0; i < namesCombined.Length; i++)
            {
                int number = namesCombined[i];
            }
        }
        public void SortLetters()
        {
            var charCount = new Dictionary<char, int>();

            foreach (var count in namesCombined.OrderBy(item => item))
            {
                if (charCount.ContainsKey(count))
                    charCount[count]++;
                else
                    charCount[count] = 1;
            }
            int aCount = 0;
            charCount.TryGetValue('a', out aCount);
            Console.WriteLine("\nLetters in Order: ");
            foreach (var pair in charCount)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
        }
    }
}
