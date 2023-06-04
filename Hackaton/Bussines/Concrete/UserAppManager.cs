using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;
using Hackaton.Models.UserApp;
using Hackaton.Models.TheClass;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.Bussines.Concrete
{
    public class UserAppManager : IUserAppService
    {
        private readonly IUserAppDal _userAppDal;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ITheClassDal _theClassDal;
        private readonly UserManager<UserApp> _userManager;

        public UserAppManager(IUserAppDal userAppDal, IMapper mapper, ApplicationDbContext context, ITheClassDal theClassDal, UserManager<UserApp> userManager)
        {
            _userAppDal = userAppDal;
            _mapper = mapper;
            _context = context;
            _theClassDal = theClassDal;
            _userManager = userManager;
        }

        public bool AddEditor(AddUserAppModel model )
        {
            UserApp userApp = _mapper.Map<UserApp>(model);
            _userAppDal.Create(userApp);
            return true;
        }

        public bool ChangeUserStatus(int userId, int statusId)
        {
            _userAppDal.GetById(userId).UserStatusId = statusId;
            return true;
        }

        public bool DeleteUser(int userId)
        {
            return _userAppDal.Delete(userId);
        }

        public bool DeleteUser()
        {
            throw new NotImplementedException();
        }

        public List<UserApp> GetAll()
        {
            return _userAppDal.GetAll();
        }

        public List<UserApp> GetAuditionList()
        {
            return _userAppDal.GetWhere(x => x.UserStatusId == 3);
        }

        public List<UserApp> GetStudents()
        {
            return _context.Users.Where(x => x.Roles.Any(x => x.Name == "Student")).ToList();
        }

        public List<UserApp> GetStudentsInThisClass(int classId)
        {
            return _context.Users.Where(x=>x.Classes.Any(x=>x.Id== classId)).ToList();
        }

        public List<UserApp> GetStudentsInThisDepartment(int departmentId)
        {
            return _userAppDal.GetWhere(x=>x.DepartmentId == departmentId);
        }

        public List<UserApp> GetStudentsInThisStatus(int statusId)
        {
            return _context.Users.Where(x=>x.UserStatusId== statusId).ToList();
        }

        public  async Task<List<UserApp>> GetTutors()
        {
            var a = await _userManager.GetUsersInRoleAsync("Tutor");
            
             var b=   new List<UserApp>(a.Select(x => (UserApp)x));
            return b;
        }

        public bool UpdateUser(UpdateTheClassModel user)
        {
            UserApp upUser = _mapper.Map<UserApp>(user);
            _context.Users.Update(upUser);
            return true;
        }

    }
}
