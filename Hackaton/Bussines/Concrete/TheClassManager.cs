using AutoMapper;
using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;
using Hackaton.Models.TheClass;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hackaton.Bussines.Concrete
{
    public class TheClassManager : ITheClassService
    {
        private readonly ITheClassDal _theClassDal;
        private readonly IMapper _mapper;
        readonly ApplicationDbContext _context;

        public TheClassManager(ITheClassDal theClassDal, IMapper mapper, ApplicationDbContext context)
        {
            _theClassDal = theClassDal;
            _mapper = mapper;
            _context = context;
        }

        public bool AddClass(AddTheClassModel theClass)
        {
            TheClass Class = _mapper.Map<TheClass>(theClass);
            _theClassDal.Create(Class);
            return true;
        }

        public bool DeleteClass(int classId)
        {
            return _theClassDal.Delete(classId);
        }

        public List<TheClass> GetClassWithIncludes(IQueryable<TheClass> classes, params Expression<Func<TheClass, object>>[] includeProperties)
        {
            IQueryable<TheClass> query = classes;

            if (includeProperties.Length == 0)
            {
                query = query.Include(d => d.Users);

                query = query.Include(d => d.ClassDates);

                return query.ToList();
            }
            
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return query.ToList();
        }

        public List<TheClass> GetAll(params Expression<Func<TheClass, object>>[] includeProperties)
        {
            IQueryable<TheClass> query = _context.Set<TheClass>();
            return GetClassWithIncludes(query, includeProperties);
        }

        public TheClass GetById(int id, params Expression<Func<TheClass, object>>[] includeProperties)
        {
            return GetClassWithIncludes(_context.Set<TheClass>().Where(o => o.Id == id), includeProperties).FirstOrDefault(); 
        }
        public List<TheClass> GetAllClasses()
        {
            return _theClassDal.GetAll();
        }

        public bool UpdateClass(UpdateTheClassModel theClass)
        {
            TheClass Class = _mapper.Map<TheClass>(theClass);
            _theClassDal.Update(Class);
            return true;
        }
    }
}
