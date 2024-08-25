using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies._3Model
{
    public class AdditionalTime
    {
        public TimeSpan Ads { get; set; }
        public TimeSpan Cleaning { get; set; }
        public AdditionalTime(TimeSpan ads, TimeSpan cleaning)
        {
            Ads = ads;
            Cleaning = cleaning;
        }
    }
}
