using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies._3Model
{
    public class AdditionalTime
    {
        // Ads and cleaning individually has specifically 15 minutes each. Enum?
        private TimeSpan Ads { get; } = new TimeSpan(0, 15, 0);
        private TimeSpan Cleaning { get; } = new TimeSpan(0, 15, 0);

        public TimeSpan GetAdditionalTime()
        {
            return Ads + Cleaning;
        }
    }
}
