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
            var intList = classGrades.Select(s => s.Split(',').Select(int.Parse).ToList().OrderBy(i => i).Take(classGrades.Count - 1).Average()).Average();
            //close. Order of ops is wrong or something. Not getting the right number

                Console.WriteLine(intList);

            //Want to set things up such that it only adds all of the items in the converted list except the lowest.
        }
    }
}
