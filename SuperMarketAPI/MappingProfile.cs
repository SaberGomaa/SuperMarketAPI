using AutoMapper;
using Entities.Models;
using Models;
using Shared.DTO;

namespace SuperMarketAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //// Admin
            CreateMap<Admin , AdminDto>();
            CreateMap<AdminDtoForCreate,Admin>();
            
            //// Product
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDtoForCreation,Product>();

            // Authentication
            CreateMap<UserForRegistrationDto, User>();

        }
    }
}
