using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;
using Hackaton.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hackaton.Bussines.Concrete
{
    public class DepartmentManager: IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        

    }
}
