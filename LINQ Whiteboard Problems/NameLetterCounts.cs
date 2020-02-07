using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Whiteboard_Problems
{
    class NameLetterCounts
    {
        //Member Variables (HAS A)
        string lettersToTest = "Terrill";
        int counter;

        //Constructor

        //Member Methods (CAN DO)
        public void CountLettersInString()
        {
            char[] lettersAsCharArray = lettersToTest.ToCharArray();
            var lettersAndCount = from x in lettersAsCharArray group x by x into g let count = g.Count() orderby count descending select new { Value = g.Key, Count = count };
            //from x in lettersAsCharArray group x by x into g let count = g.Count() orderby count descending select new { Value = g.Key, Count = count };
            //Need to select each character and test it against all the others? Kind of like a for loop? But the Select function serves the same purpose

            Console.WriteLine(lettersAndCount.Count, lettersAsCharArray.Key);
            
        }
    }
}
