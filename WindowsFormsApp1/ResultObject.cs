using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ResultObject
    {
        public int CurrentIndex { get; set; } = 0;
        /// <summary>
        /// string lưu phép tính
        /// </summary>
        public string ValueRaned { get; set; } = "";
        public int RanedNumber { get; set; } = 0;
        public double SumValue { get; set; } = 0;
        public bool IsFinish { get; set; } = false;
        public List<string> ValueRaneds { get; set; } = new List<string>();
    }
}
