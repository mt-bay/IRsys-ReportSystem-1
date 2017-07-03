using CommandLine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRsys_ReportSystem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Options option = new Options();
            Parser.Default.ParseArguments<Options>(args).
                MapResult((Options opt) =>
                {
                    option = opt;
                    return 0;
                },
                err => 1);

            int numOfDocument = 1000;

            List<int> correctDocument = new List<int>
            {
                 50,  81,  83, 223, 295, 355, 391, 453, 531, 536,
                568, 572, 633, 740, 819, 861, 899, 906, 916, 953
            };

            List<int> answerSet = new List<int>
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

            List<PresitionRecall> presitionRecall = Statistics.GetCompletedPresitionRecalls(correctDocument, answerSet).ToList();

            string outString = string.Empty;
            using (StreamWriter writer = option.OutTo == null ? new StreamWriter(Console.OpenStandardOutput()) : new StreamWriter(option.OutTo))
            {
                if (option.IsCsvFormat)
                {
                    writer.WriteLine("Presition,Recall");
                }
                foreach(PresitionRecall pr in presitionRecall)
                {
                    writer.WriteLine(pr.ToString(option.IsCsvFormat));
                }
            }

            Console.WriteLine("11点平均適合率 : {0}", Statistics.Get11PointAveragePrecision(presitionRecall));
            Console.WriteLine("平均適合率 : {0}", Statistics.GetAveragePrecision(presitionRecall, correctDocument.Count()));

            return;
        }
    }
}
