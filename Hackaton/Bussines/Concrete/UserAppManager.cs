using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;
using Hackaton.Models.AddUserModel;
using Hackaton.Models.TheClass;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.Bussines.Concrete
{
    public class UserAppManager : IUserAppService
    {
        private readonly IUserAppDal _userAppDal;
        private readonly ApplicationDbContext _context;
        readonly UserManager<UserApp> _UserManager;

        public UserAppManager(IUserAppDal userAppDal, UserManager<UserApp> userManager, ApplicationDbContext context)
        {
            _userAppDal = userAppDal;
            _UserManager = userManager;
            _context = context;
        }

        public bool AddEditor(AddUserAppModel model )
        {
            throw new NotImplementedException();
        }

        public bool ChangeUserStatus(int userId, int statusId)
        {
            throw new NotImplementedException();
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
            return null;
        }

        public List<UserApp> GetStudentsInThisClass(int classId)
        {
            //        var query = _context.Users
            //.Join(
            //    _context.use,
            //    customer => customer.CustomerId,
            //    invoice => invoice.Customer.CustomerId,
            //    (customer, invoice) => new
            //    {
            //        InvoiceID = invoice.Id,
            //        CustomerName = customer.FirstName + "" + customer.LastName,
            //        InvoiceDate = invoice.Date
            //    }
            //).ToList();
            return null;

        }

        public List<UserApp> GetStudentsInThisDepartment(int departmentId)
        {
            return null;
        }

        public List<UserApp> GetStudentsInThisStatus(int statusId)
        {
            return null;
        }

        public  async Task<List<UserApp>> GetTutors()
        {
            var a = await _UserManager.GetUsersInRoleAsync("Tutors");
            return new List<UserApp>(a.Select(x => (UserApp)x));
        }

        public bool UpdateUser(UpdateTheClassModel user)
        {
            throw new NotImplementedException();
        }
    }
}
