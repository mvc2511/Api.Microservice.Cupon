using Api.Microservice.Cupon.Models.Dto;
using AutoMapper;

namespace Api.Microservice.Cupon.Aplications
{
    public class MappingProfile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(
                config =>
                {
                    config.CreateMap<CuponDto, Cupon.Models.Cupon>();
                    config.CreateMap<Cupon.Models.Cupon, CuponDto>();
                });
            return mappingConfig;
        }
    }
}
