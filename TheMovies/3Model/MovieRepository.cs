using TheMovies.MVVM;

namespace TheMovies._3Model
{
    public class MovieRepository : IRepo<Movie>
    {
        private Datahandler datahandler = new Datahandler();

        public List<Movie> movieRepo;

        public MovieRepository() 
        {
            // Load movies on launch
            movieRepo = new List<Movie>(datahandler.LoadMovies());
        }

        public void Create(Movie newMovie)
        {
            movieRepo.Add(newMovie);
        }
        public List<Movie> Read()
        {
            return movieRepo;
        }
        public void Update(List<Movie> newMovies)
        {
            movieRepo = newMovies;
        }
        public void Delete(int pos)
        {
            movieRepo.RemoveAt(pos);
        }
    }
}
