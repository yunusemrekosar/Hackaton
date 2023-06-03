using Hackaton.Data.Entity;
using Hackaton.Models.AddUserModel;
using Hackaton.Models.Class;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace Hackaton.Bussines.Abstract
{
    public interface IUserAppService
    {
        public List<UserApp> GetTutors(); 
        public List<UserApp> GetStudents();
        public List<UserApp> GetAuditionList();
        public bool ChangeUserStatus(int userId, int statusId);
        public List<UserApp> GetStudentsInThisClass(int classId);
        public List<UserApp> GetStudentsInThisDepartment(int departmentId);
        public List<UserApp> GetStudentsInThisStatus(int statusId);
        public bool UpdateUser(UpdateClassModel user);   
        public List<UserApp> GetAll();
        public bool DeleteUser();
        public bool AddEditor(AddUserModel model);
    }
}
