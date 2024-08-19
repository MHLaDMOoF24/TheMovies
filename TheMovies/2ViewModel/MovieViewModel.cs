using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TheMovies._1View;

namespace TheMovies._2ViewModel
{
    public class MovieViewModel : INotifyPropertyChanged
    {
        private string _title;
        private TimeSpan _duration;
        private string _genre;

        public string Title
        { 
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }
        public TimeSpan Duration
        { 
            get { return _duration; }
            set
            {
                if (_duration != value)
                {
                    _duration = value;
                    OnPropertyChanged(nameof(Duration));
                }
            }
        }
        public string Genre
        { 
            get { return _genre; }
            set
            {
                if (_genre != value)
                {
                    _genre = value;
                    OnPropertyChanged(nameof(Genre));
                }
            }
        }

        public MovieViewModel(string title, string duration, string genre)
        {
            Title = title;
            Duration = TimeSpan.Parse(duration);
            Genre = genre;
        }



        public override string ToString()
        {
            return $"{Title},{Duration.ToString()},{Genre}";
        }



        // INotifyPropertyChanged handler
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
