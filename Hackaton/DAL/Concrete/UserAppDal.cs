﻿using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;


namespace Hackaton.DAL.Concrete
{
    public class UserAppDal : BaseDal<UserApp>, IUserAppDal
    {
        public UserAppDal(ApplicationDbContext context) : base(context)
        {
        }
    }
}
