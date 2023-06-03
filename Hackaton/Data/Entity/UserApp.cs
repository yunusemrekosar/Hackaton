using Hackaton.Data.Entity.Common;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hackaton.Data.Entity
{
    public class UserApp : IdentityUser<int>, IBaseClass
    {
        public string FullName { get; set; }


        public List<TheClass> Classes { get; set; }

        public UserStatus UserStatus { get; set; }
        public int UserStatusId { get; set; }

        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }


    }
}
