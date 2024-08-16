using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies._3Model
{
    internal interface IRepo<T>
    {
        void Create(T obj);
        //void Read();
        //void Update();
        void Delete(int pos);
    }
}
