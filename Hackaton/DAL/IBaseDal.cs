using Hackaton.Data.Entity.Common;
using System.Linq.Expressions;

namespace Hackaton.DAL
{
    public interface IBaseDal<T> where T : class, IBaseClass
    {
        public bool Create(T t);

        public List<T> GetAll();

        public T GetById(int id);

        public bool Delete(int id);

        public bool Update(T t);

        public List<T> GetWhere(Expression<Func<T,bool>> expression);

    }
}
