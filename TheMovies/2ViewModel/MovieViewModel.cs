using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies._1View;

namespace TheMovies._2ViewModel
{
    public class MovieViewModel
    {
        private string _title;
        private string _duration;
        private string _genre;


        public string Title
        { get { return _title; } set {  _title = value; } }

        public string Duration
        { get { return _duration; } set { _duration = value; } }

        public string Genre
        { get { return _genre; } set { _genre = value; } }

        public MovieViewModel() 
        { 
            //Movies = new ObservableCollection<movie>();
            
        }



    }
}
