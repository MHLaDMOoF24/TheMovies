using TheMovies.MVVM;

namespace TheMovies._3Model
{
    public class CinemaRepository : IRepo<Cinema>
    {
        public Cinema cinemaRepo;

        public CinemaRepository() 
        {

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
