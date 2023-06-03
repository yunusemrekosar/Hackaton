using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hackaton.Data.Entity.Common
{
    public class BaseClass : IBaseClass
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime")]

        public DateTime CreatedOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
