using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies._3Model
{
    public class RunTime
    {
        private AdditionalTime _additionalTime = new AdditionalTime();

        public DateOnly Date { get; set; }
        public TimeOnly TimeSlot { get; set; }
        public TimeSpan AddedTime { get; }

        public RunTime(DateOnly date, TimeOnly time)
        {
            Date = date;
            TimeSlot = time;
            AddedTime = _additionalTime.GetAdditionalTime();
        }

        public override string ToString()
        {
            return $"{Date};{TimeSlot}";
        }
    }
}
