using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Hackaton.DAL.Concrete
{
    public class RoleAppDal : BaseDal<RoleApp>, IRoleAppDal
    {
        readonly ApplicationDbContext _context;

        public RoleAppDal(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
