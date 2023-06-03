using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;
using Hackaton.Data.Entity;

namespace Hackaton.Bussines.Concrete
{
    public class UserAppManager : IUserAppService
    {
        private readonly IUserAppDal _userAppDal;

        public UserAppManager(IUserAppDal userAppDal)
        {
            _userAppDal = userAppDal;
        }

        public bool ChangeUserStatus(int UserId, int statusId)
        {
            throw new NotImplementedException();
        }

        public bool ChangeUserStatus(UserApp user)
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
    }
}
