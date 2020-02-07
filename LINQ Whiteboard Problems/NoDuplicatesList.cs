using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Whiteboard_Problems
{
    class NoDuplicatesList
    {
        //Member Variables (HAS A)
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

        //Constructor

        //Member Methods (CAN DO)
        public void SelectSingleInstance()
        {
            var onlyOneOfEach = names.Distinct();
            foreach (string name in onlyOneOfEach)
            {
                Console.WriteLine(name);

            }
        }
    }
}
