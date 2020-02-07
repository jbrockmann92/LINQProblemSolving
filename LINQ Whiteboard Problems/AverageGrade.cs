using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Whiteboard_Problems
{
    class AverageGrade
    {

        //Member Variables (HAS A)
        List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
        //Need to convert to ints by comma
        //Need to get four lists of ints that contain all but the lowest number
        //Need to average each list and return and int
        //Need to add those four numbers together, then divide by four

        //Member Methods (CAN DO)

        //Convert to ints
        public void ConvertToIntArray()
        {
            //Might want to use what we learned in class today about passing in a method as a variable??
            for (int i = 0; i < classGrades.Count; i++)
            {
                int[] gradesAsInts = classGrades[i].Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            }
        }
    }
}
