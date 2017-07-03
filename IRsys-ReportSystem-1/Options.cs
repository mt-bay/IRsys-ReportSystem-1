using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRsys_ReportSystem_1
{
    public class Options
    {
        [Option('c', "csv")]
        public bool IsCsvFormat { get; set; }
        [Option('f', "file", Default = null)]
        public string OutTo { get; set; }
    }
}
