using AutoMapper;
using Hackaton.Data.Entity;
using Hackaton.Models.TheClass;
using Hackaton.Models.UserApp;

namespace Hackaton.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UpdateTheClassModel, TheClass>();
            CreateMap<TheClass, UpdateTheClassModel>();

            CreateMap<AddTheClassModel, TheClass>();
            CreateMap<TheClass, AddTheClassModel>();

            CreateMap<AddUserAppModel, UserApp>();
            CreateMap<UserApp, AddUserAppModel>();


        }
    }
}
