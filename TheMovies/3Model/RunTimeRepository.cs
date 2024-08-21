using TheMovies.MVVM;

namespace TheMovies._3Model
{
    public class RunTimeRepository : IRepo<RunTime>
    {
        public RunTime RunTimeRepo;

        public RunTimeRepository()
        {

        }

        public void Create(RunTime obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int pos)
        {
            throw new NotImplementedException();
        }

        public List<RunTime> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(List<RunTime> list)
        {
            throw new NotImplementedException();
        }
    }
}
