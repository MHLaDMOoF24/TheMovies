using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies._3Model
{
    public class RunTime
    {
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public AdditionalTime AdditionalTime { get; set; }

        public RunTime(DateOnly date, TimeOnly time, AdditionalTime additionalTime)
        {
            Date = date;
            Time = time;
            AdditionalTime = additionalTime;
        }

        public override string ToString()
        {
            return $"{Date} - {Time}";
        }
    }
}
