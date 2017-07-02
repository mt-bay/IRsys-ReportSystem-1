using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRsys_ReportSystem_1
{
    public static class Statistics
    {
        public static int GetRecall(List<int> correct, List<int> answerSet)
        {
            int returns = 0;
            foreach(int a in answerSet)
            {
                returns += answerSet.Contains(a) ? 1 : 0;
            }

            return returns;
        }
    }
}
