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

        private MovieRepository movieRepo;
        public ObservableCollection<MovieViewModel> Movies { get; } = new ObservableCollection<MovieViewModel>();

        public MainViewModel()
        {
            // Start repo connection and load movies from it
            movieRepo = new MovieRepository();
            GetMovies();
        }



        public void NewMovie()
        {
            Movies.Add(new MovieViewModel("","00:00",""));
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
            // Read Model layer movies to ViewModel movies
            foreach (Movie movie in movieRepo.movieRepo)
            {
                // Read each movie, then split up the information
                string[] input = movie.ToString().Split(",");
                // Add previous information to a new movie
                if (input.Length == 3) 
                    Movies.Add(new MovieViewModel(input[0], input[1], input[2]));
            }
        }
    }
}
