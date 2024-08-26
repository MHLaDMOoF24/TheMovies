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
        private int _cinemaHallID;

        public int CinemaHallID
        {
            get { return _cinemaHallID; }
        }


        public CinemaHall(int cinemaHallID)
        {
            _cinemaHallID = cinemaHallID;
        }

        

        public override string ToString()
        {
            return $"Sal {CinemaHallID}";
        }
    }

}
