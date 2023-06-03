using Hackaton.Data.Entity.Common;
using Hackaton.Data.Entity.Inheritance;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hackaton.Data.Entity
{
    public class UserApp : IdentityUser<int>, IBaseClass
    {
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }
    }
}
