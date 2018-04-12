using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2017WPF.Days
{
    public class DayInput
    {
        public int Day;
        public ExecutionType ExecutionType;
    }

    public enum ExecutionType
    {
        Simple,
        Advanced
    }
}
