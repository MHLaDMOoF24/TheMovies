using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies._3Model;

namespace TheMovies._2ViewModel
{
    internal class MainViewModel
    {
        private Datahandler datahandler = new Datahandler;
        private MovieRepository movieRepo = new MovieRepository;
        public ObservableCollection<MovieViewModel> Movies;
    }
}
