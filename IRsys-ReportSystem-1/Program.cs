using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRsys_ReportSystem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDocument = 1000;

            List<int> correctDocument = new List<int>
            {
                 50,  81,  83, 223, 295, 355, 391, 453, 531, 536,
                568, 572, 633, 740, 819, 861, 899, 906, 916, 953
            };

            List<int> anserSet = new List<int>
            {
                328, 823, 150, 305, 601,
                794, 682, 765, 819, 223,
                982, 294, 264, 141, 236,
                994,  83, 981, 295, 355,
                953, 121, 668, 249, 266,
                  1, 899, 691, 864, 715,
                114, 861, 568, 906, 201,
                337, 536, 740, 202, 916,
                391,  50, 175,  27, 453,
                572, 801, 531,  81, 633
            };


        }
    }
}
