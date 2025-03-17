using Application.DTOs;
using AutoMapper;
using Domain.Core.Entities;

namespace Application.MapProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Customer, CustomerDTO>();
        }
    }
}
