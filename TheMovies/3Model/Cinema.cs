using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies._3Model
{
    public class Cinema
    {
        private string _location;
        private List<CinemaHall> _halls;

        public string Location 
        { 
            get { return _location; } 
        }
        public List<CinemaHall> Halls 
        {
            get { return _halls; } 
        }

        public Cinema(string location, int numHalls)
        {
            _location = location;
            _halls = new List<CinemaHall>();
            for (int i = 0; i < numHalls; i++)
            {
                _halls.Add(new CinemaHall(i + 1));
            }
        }

        public override string ToString()
        {
            return Location;
        }
    }
}
