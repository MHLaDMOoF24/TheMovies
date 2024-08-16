using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies._3Model
{
    public class Movie
    {
        private string _title;
        private TimeSpan _duration;
        private string _genre;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public TimeSpan Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public Movie(string title, string duration, string genre)
        {
            Title = title;
            Duration = TimeSpan.Parse(duration);
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Title},{Duration.ToString()},{Genre}";
        }
    }
}
