using Hackaton.Data.Entity.Common;

namespace Hackaton.DAL
{
    public interface IBaseDal<T> where T : BaseClass
    {
        public bool Create(T t);

        public List<T> GetAll();

        public T GetById(int id);

        public bool Delete(int id);

        public bool Update(T t);

    }
}
