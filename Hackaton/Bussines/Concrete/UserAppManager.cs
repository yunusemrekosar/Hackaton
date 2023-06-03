using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;
using Hackaton.Data.Entity;
using Hackaton.Models.AddUserModel;
using Hackaton.Models.Class;

namespace Hackaton.Bussines.Concrete
{
    public class UserAppManager : IUserAppService
    {
        private readonly IUserAppDal _userAppDal;

        public UserAppManager(IUserAppDal userAppDal)
        {
            _userAppDal = userAppDal;
        }

        public bool AddEditor(AddUserModel model )
        {
            throw new NotImplementedException();
        }

        public bool ChangeUserStatus(int userId, int statusId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser()
        {
            throw new NotImplementedException();
        }

        public List<UserApp> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<UserApp> GetAuditionList()
        {
            throw new NotImplementedException();
        }

        public List<UserApp> GetStudents()
        {
            throw new NotImplementedException();
        }

        public List<UserApp> GetStudentsInThisClass(int classId)
        {
            throw new NotImplementedException();
        }

        public List<UserApp> GetStudentsInThisDepartment(int departmentId)
        {
            throw new NotImplementedException();
        }

        public List<UserApp> GetStudentsInThisStatus(int statusId)
        {
            throw new NotImplementedException();
        }

        public List<UserApp> GetTutors()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UpdateClassModel user)
        {
            throw new NotImplementedException();
        }
    }
}
