using AutoMapper;
using GreenHouseNG.Data;
using GreenHouseNG.Models.User;

namespace GreenHouseNG.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<UserCreateDto, TbUser>().ReverseMap();
            CreateMap<UserReadOnlyDto, TbUser>().ReverseMap();
            CreateMap<UserUpdateDto, TbUser>().ReverseMap();

           /* CreateMap<TbUser, UserReadOnlyDto>()
              .ForMember(q => q.UserRole, d => d.MapFrom(map => $"{map.T}"))
              .ReverseMap();*/

        }
    }
}
