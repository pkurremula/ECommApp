using AutoMapper;
using ECommAppAPI.DTOs;
using ECommAppCore.Entities;
using Microsoft.Extensions.Configuration;

namespace ECommAppAPI.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDTO, string>
    {
        private readonly IConfiguration _config;

        public ProductUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(
            Product source, ProductToReturnDTO destination, 
            string destMember, ResolutionContext context)
        {
            if(!string.IsNullOrEmpty(source.PictureURL))
            {
                return _config["ApiUrl"] + source.PictureURL;
            }

            return null;
        }
    }
}
