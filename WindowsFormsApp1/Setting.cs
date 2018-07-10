using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Setting
    {
        public int RandomTime { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int WaitingForRandom { get; set; }
        public int WaitingForResult { get; set; }
        public int NumOfExpression { get; set; } = 5;
        public int ShowResultSetting { get; set; } = 1;
        public string Operator { get; set; } = "+";
    }
}
