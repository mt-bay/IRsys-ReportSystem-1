using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRsys_ReportSystem_1
{
    public class PresitionRecall
    {
        public PresitionRecall(List<int> correct, List<int> answerSet)
        {
            Index = answerSet.Count() - 1;
            Presition = Statistics.GetPresition(correct, answerSet);
            Recall = Statistics.GetRecall(correct, answerSet);
        }

        public int Index { get; set; }

        public decimal Presition { get; set; }
        public decimal Recall { get; set; }


        public string ToString(bool isCsvFormat)
        {
            if(isCsvFormat)
            {
                return Index.ToString() + "," + Presition.ToString() + "," + Recall.ToString();
            }
            else
            {
                return "Index : " + Index.ToString() + ", Presition : " + Presition.ToString() + ", Recall : " + Recall.ToString();
            }
        }
    }
}
