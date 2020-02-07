using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Whiteboard_Problems
{
    public class THTest
    {
        //Return the full string for each string that containst the substring 'th'

        //Member Variables (HAS A)
        public List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };


        //Constructor

        //Member Methods (CAN DO)
        public void SelectTHStrings()
        {

            var thStrings = words.Where(m => m.Contains("th")).ToList();

            foreach (string word in thStrings)
            { Console.WriteLine(word); }
        }
    }
}
