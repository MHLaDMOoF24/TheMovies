using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies._3Model
{
    public class CinemaHall
    {
        public int CinemaHallID { get; set; }

        public CinemaHall(int cinemaHallID)
        {
            CinemaHallID = cinemaHallID;
        }

        public override string ToString()
        {
            return $"Hall {CinemaHallID}";
        }
    }

}
