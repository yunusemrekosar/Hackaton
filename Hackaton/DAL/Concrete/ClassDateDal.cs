using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;

namespace Hackaton.DAL.Concrete
{
    public class ClassDateDal : BaseDal<ClassDate>, IClassDateDal
    {
        public ClassDateDal(ApplicationDbContext context) : base(context)
        {
        }
    }
}
