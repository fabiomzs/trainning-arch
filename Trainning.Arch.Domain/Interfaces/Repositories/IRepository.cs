using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainning.Arch.Domain.Interfaces.Repositories
{
    interface IRepository<T> where T : Entity
    {
        void Add(T entity);
        void Delete(int id);
        T Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();

    }
}
