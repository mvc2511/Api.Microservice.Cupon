using Api.Microservice.Cupon.Models.Dto;
using AutoMapper;

namespace Api.Microservice.Cupon.Aplications
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CuponDto, Cupon.Models.Cupon>().ReverseMap();
        }
    }
}
