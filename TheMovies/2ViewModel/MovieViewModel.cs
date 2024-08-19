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
        public string Duration
        { 
            get { return _duration.ToString(@"hh\:mm"); }
            set
            {
                if (_duration.ToString(@"hh\:mm") != value)
                {
                    _duration = TimeSpan.Parse(value);
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
            Duration = duration;
            Genre = genre;
        }



        public override string ToString()
        {
            return $"{Title};{Duration};{Genre}";
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
