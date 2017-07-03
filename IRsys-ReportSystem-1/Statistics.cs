using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRsys_ReportSystem_1
{
    public static class Statistics
    {
        public static IEnumerable<PresitionRecall> GetPresitionRecalls(List<int> correct, List<int> answerSet)
        {
            for (int i = 0; i < answerSet.Count(); ++i)
            {
                yield return new PresitionRecall(correct, answerSet.GetRange(0, i + 1));
            }
        }

        public static IEnumerable<PresitionRecall> GetCompletedPresitionRecalls(List<int> correct, List<int> answerSet)
        {
            PresitionRecall prev = null;
            PresitionRecall buffer;
            for(int i = 0; i < answerSet.Count(); ++i)
            {
                buffer = new PresitionRecall(correct, answerSet.GetRange(0, i + 1));
                if(prev == null || prev.Recall != buffer.Recall)
                {
                    prev = buffer;
                    yield return buffer;
                }
            }
        }


        public static decimal GetPresition(List<int> correct, List<int> answerSet)
        {
            return (decimal)correct.Intersect(answerSet).Count() / answerSet.Count();
        }


        public static decimal GetRecall(List<int> correct, List<int> answerSet)
        {
            return (decimal)correct.Intersect(answerSet).Count() / correct.Count();
        }


        public static decimal Get11PointAveragePrecision(List<PresitionRecall> presitionRecalls)
        {
            return presitionRecalls.Sum(e => ((int)(e.Recall * (decimal)Math.Pow(10, 2)) % 10 == 0) ? e.Presition : 0) / 11;
        }


        public static decimal GetAveragePrecision(List<PresitionRecall> presitionRecalls, int correctDocumentNum)
        {
            return presitionRecalls.Sum(e => e.Presition) / correctDocumentNum;
        }
    }
}
