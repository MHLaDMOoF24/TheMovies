using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies._3Model
{
    public class MovieRepository : IRepo
    {
        private List<Movie> movieRepo = new List<Movie>();


        public void Create()
        {
            movieRepo.Add(new Movie());
        }
        //public void Read(){}
        //public void Update(){}
        public void Delete()
        {
            movieRepo.RemoveAt(0);
        }
    }
}
