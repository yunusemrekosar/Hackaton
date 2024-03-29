﻿using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;
using Hackaton.Models.UserApp;
using Hackaton.Models.TheClass;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Hackaton.Bussines.Concrete
{ //end
    public class UserAppManager : IUserAppService
    {
        private readonly IUserAppDal _userAppDal;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ITheClassDal _theClassDal;
        private readonly UserManager<UserApp> _userManager;
        private readonly IRoleAppDal _roleAppDal;

        public UserAppManager(IUserAppDal userAppDal, IMapper mapper, ApplicationDbContext context, ITheClassDal theClassDal, UserManager<UserApp> userManager, IRoleAppDal roleAppDal)
        {
            _userAppDal = userAppDal;
            _mapper = mapper;
            _context = context;
            _theClassDal = theClassDal;
            _userManager = userManager;
            _roleAppDal = roleAppDal;
        }

        public bool AddEditor(AddUserAppModel model ) //todo: gerekli degil?
        {
            UserApp userApp = _mapper.Map<UserApp>(model);
            _userAppDal.Create(userApp);
            return true;
        }

        public async Task<bool> ChangeUserRole(int userId, int roleId)
        {
            try
            {
                string roleName = _roleAppDal.GetWhere(x => x.Id == roleId).First().Name;
                UserApp user = _userAppDal.GetById(userId);
                await _userManager.AddToRoleAsync(user, roleName);
                return true;
            }
            catch
            {
                return false;
            }

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

        public List<UserApp> GetAll()
        {
            return _userAppDal.GetAll();
        }

        public List<UserApp> GetAuditionList()
        {
            return _userAppDal.GetWhere(x => x.UserStatusId == 3);
        }

        public async Task<List<UserApp>> GetStudents()
        {
            var a = await _userManager.GetUsersInRoleAsync("Student");
            foreach (var item in a)
            {
                item.Department = _context.Departments.FirstOrDefault(x => x.Id == item.DepartmentId);
            }
            return new List<UserApp>(a.Select(x => (UserApp)x));
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
            foreach (var item in a)
            {
                item.Department = _context.Departments.FirstOrDefault(x => x.Id == item.DepartmentId);
            }

            return new List<UserApp>(a.Select(x => (UserApp)x));
        }

        public async Task<List<UserApp>> GetUnknownList()
        {
            var a = await _userManager.GetUsersInRoleAsync("Unknown");
            foreach (var item in a)
            {
                item.Department = _context.Departments.FirstOrDefault(x => x.Id == item.DepartmentId);
            }
            return new List<UserApp>(a.Select(x => (UserApp)x));
        }

        public UserApp GetUserById(int userId)
        {
            return _userAppDal.GetById(userId);
        }

        public bool UpdateUser(UpdateTheClassModel user)
        {
            UserApp upUser = _mapper.Map<UserApp>(user);
            _userAppDal.Update(upUser);
            return true;
        }

        public bool UpdateUserAudition(GetAuditionModel user)
        {
            if (user.PhoneNumber != null)
            {
                UserApp upUser = _mapper.Map<UserApp>(user);
                upUser.UserStatusId = 3;
                _userAppDal.Update(upUser);
                return true;
            }
            return false;
        }
    }
}
