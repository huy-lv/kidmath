using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ResultObjetct
    {
        public int CurrentIndex { get; set; } = 0;
        public string ValueRaned { get; set; } = "";
        public int RanedNumber { get; set; } = 0;
        public int SumValue { get; set; } = 0;
        public bool IsFinish { get; set; } = false;
        public List<string> ValueRaneds { get; set; } = new List<string>();
    }
}
