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
        public MovieRepository movieRepo = new MovieRepository();

        public MainViewModel()
        {

        }

    }
}
