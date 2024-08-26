using TheMovies.MVVM;

namespace TheMovies._3Model
{
    public class CinemaRepository : IRepo<Cinema>
    {
        public List<Cinema> cinemaRepo;
        public CinemaRepository() 
        {
            // Initalized internally for now, consider loading from file
            cinemaRepo = new List<Cinema>
             {
                new Cinema("Hjerm", 4),
                new Cinema("Videbaek", 3),
                new Cinema("Thorsminde", 2),
                new Cinema("Raehr", 3)
             };
        }

        public void Create(Cinema obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int pos)
        {
            throw new NotImplementedException();
        }

        public List<Cinema> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(List<Cinema> list)
        {
            throw new NotImplementedException();
        }
    }
}
