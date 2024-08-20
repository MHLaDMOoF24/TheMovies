using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies._3Model
{
    internal interface IRepo<T>
    {
        // CRUD implementations, OBS Read?
        public void Create(T obj);
        public List<T> Read();
        public void Update(List<T> list);
        public void Delete(int pos);
    }
}
