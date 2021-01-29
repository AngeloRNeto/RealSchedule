using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealSchedule.Domain.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        int Insert(T agenda);
        void Update(T agenda);
        void Delete(T agenda);
        T GetById(int id);
        List<T> GetAll<TEntity>();

    }
}
