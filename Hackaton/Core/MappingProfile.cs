using AutoMapper;
using Hackaton.Data.Entity;
using Hackaton.Models.TheClass;

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


        }
    }
}
