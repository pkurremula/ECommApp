using AutoMapper;
using ECommAppAPI.DTOs;
using ECommAppCore.Entities;

namespace ECommAppAPI.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDTO>()
                .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
                .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                .ForMember(d => d.PictureURL, o => o.MapFrom<ProductUrlResolver>());
        }
    }
}
