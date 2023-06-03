using Hackaton.Data.Entity;

namespace Hackaton.Bussines.Abstract
{
    public interface IUserAppService
    {
        public List<UserApp> GetTutors(); 
        public List<UserApp> GetStudents();
        public List<UserApp> GetAuditionList();
        public bool ChangeUserStatus(int userId, int statusId);
        public bool ChangeUserStatus(UserApp user);
        public List<UserApp> GetStudentsInThisClass(int classId);
        public List<UserApp> GetStudentsInThisDepartment(int departmentId);
        public List<UserApp> GetStudentsInThisStatus(int statusId);
    }
}
