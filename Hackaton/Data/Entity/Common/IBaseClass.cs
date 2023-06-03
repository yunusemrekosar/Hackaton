﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hackaton.Data.Entity.Common
{
    public class BaseClass
    {
        public virtual int Id { get; set; };

        public virtual DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }

    }
}
