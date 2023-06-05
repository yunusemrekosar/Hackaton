using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;

namespace Hackaton.Bussines.Concrete
{
    public class ClassDateManager: IClassDateService
    {
        private readonly IClassDateDal _classDateDal;

        public ClassDateManager(IClassDateDal classDateDal)
        {
            _classDateDal = classDateDal;
        }


    }
}
