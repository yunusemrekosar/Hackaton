using Hackaton.Data;
using Hackaton.Data.Entity;
using Hackaton.Data.Entity.Common;

namespace Hackaton.DAL
{
    public class BaseDal<T> : IBaseDal<T> where T : class, IBaseClass
    {

        readonly ApplicationDbContext _context;

        public BaseDal(ApplicationDbContext context)
        {
                _context = context;
        }

        public bool Create(T t)
        {
            try
            {

                _context.Set<T>().Add(t);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var t = GetById(id);
                t.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public virtual List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            try
            {
                return _context.Set<T>().First(t => t.Id == id);

            }
            catch  //todo: zaman kalırsa hata log yap
            {
                return null;
            }
        }

        public bool Update(T t)
        {
            try
            {
                _context.Set<T>().Update(t);
                _context.SaveChanges();
                return true;

            }
            catch  //todo: zaman kalırsa hata log yap
            {
                return false;
            }

        }

    }
}
