using Hackaton.Data.Entity.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hackaton.Data.Entity
{
    public class RoleApp : IdentityRole<int>, IBaseClass
    {
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }

        public List<UserApp> Users { get; set; }
    }
}
