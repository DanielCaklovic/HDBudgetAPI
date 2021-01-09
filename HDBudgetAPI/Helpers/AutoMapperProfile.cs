using AutoMapper;
using HDBudgetAPI.Entities;
using HDBudgetAPI.Models.Users;

namespace HDBudgetAPI.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}