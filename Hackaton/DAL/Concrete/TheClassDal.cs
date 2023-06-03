using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;

namespace Hackaton.DAL.Concrete
{
    public class TheClassDal : BaseDal<ClassDate>, IClassDateDal
    {
        public TheClassDal(ApplicationDbContext context) : base(context)
        {
        }
    }
}
