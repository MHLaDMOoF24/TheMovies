using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies._3Model
{
    internal class Movie
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private TimeOnly _duration;
        public TimeOnly Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private string _genre;
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
    }
}
