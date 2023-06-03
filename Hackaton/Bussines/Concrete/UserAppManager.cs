﻿using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;
using Hackaton.Models.AddUserModel;
using Hackaton.Models.TheClass;

namespace Hackaton.Bussines.Concrete
{
    public class UserAppManager : IUserAppService
    {
        private readonly IUserAppDal _userAppDal;
        private readonly ApplicationDbContext _context;

        public UserAppManager(IUserAppDal userAppDal)
        {
            _userAppDal = userAppDal;
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
            //        var query = _context.Users
            //.Join(
            //    _context.UserStatus,
            //    u => u.Id,
            //    r => r.
            //    (u, r) => new
            //    {
            //        InvoiceID = invoice.Id,
            //        CustomerName = customer.FirstName + "" + customer.LastName,
            //        InvoiceDate = invoice.Date
            //    }
            //).ToList();
            //        return query
            return null;
        }

        public List<UserApp> GetStudentsInThisClass(int classId)
        {
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

        public List<UserApp> GetTutors()
        {
            return null;
        }

        public bool UpdateUser(UpdateTheClassModel user)
        {
            throw new NotImplementedException();
        }
    }
}
