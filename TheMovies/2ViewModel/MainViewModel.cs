using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies._3Model;

namespace TheMovies._2ViewModel
{
    public class MainViewModel
    {
        private Datahandler datahandler = new Datahandler();

        private MovieRepository movieRepo = new MovieRepository();
        public ObservableCollection<MovieViewModel> Movies = new ObservableCollection<MovieViewModel>();

        public MainViewModel()
        {
            GetMovies();
        }



        public void NewMovie()
        {
            Movies.Add(new MovieViewModel("-","00:00","-"));
        }

        public void DeleteMovie(int pos)
        {
            if (pos < Movies.Count && pos > -1)
            {
                Movies.RemoveAt(pos);
            }
        }

        public void SaveMovies()
        {
            datahandler.SaveMovies(Movies);
        }



        public void GetMovies()
        {
            // Read the ToString() from Model layer movies
        }
    }
}
