using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Whiteboard_Problems
{
    class NameLetterCounts
    {
        string lettersToTest = "terrill";

        public void CountLettersInString()
        {
            char[] lettersAsCharArray = lettersToTest.ToLower().OrderBy(x => x).ToArray();
            var lettersAndCount = from x in lettersAsCharArray group x by x into g let count = g.Count() select new { Value = g.Key, Count = count };
            var lettersAndCountAlphabetical = lettersAndCount.OrderBy(x => x);

            foreach (var x in lettersAndCount)
            {
                Console.WriteLine($"{x.Value}{x.Count}");
            }
        }
    }
}
