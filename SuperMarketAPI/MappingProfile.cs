using AutoMapper;
using Models;
using Shared.DTO;

namespace SuperMarketAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Admin , AdminDto>();
        }
    }
}
