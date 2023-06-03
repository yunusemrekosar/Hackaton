using AutoMapper;
using Hackaton.Data.Entity;
using Hackaton.Models.Class;

namespace Hackaton.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UpdateClassModel, TheClass>();
            CreateMap<TheClass, UpdateClassModel>();

            CreateMap<AddClassModel, TheClass>();
            CreateMap<TheClass, AddClassModel>();


        }
    }
}
