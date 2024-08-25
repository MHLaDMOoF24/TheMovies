using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies._3Model
{
    public class Cinema
    {
        public string Location { get; set; }
        public List<CinemaHall> Halls { get; set; }

        public Cinema(string location)
        {
            Location = location;
            Halls = new List<CinemaHall>();
        }

        public override string ToString()
        {
            return Location;
        }
    }
}
