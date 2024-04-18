using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projekt_ASP_NET.Models;
using Projekt_ASP_NET.ViewModels;

namespace Projekt_ASP_NET.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BranchViewModel, Branch>().ReverseMap();

            CreateMap<User, SelectListItem>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Email));

            CreateMap<RegisterViewModel, User>().ReverseMap();

            CreateMap<Vehicle, VehicleViewModel>()
               .ForMember(dest => dest.Vehicle, opt => opt.MapFrom(src => src))
               .ForMember(dest => dest.Branches, opt => opt.Ignore());

            CreateMap<Vehicle, VehicleShowViewModel>()
            .ForMember(dest => dest.Vehicles, opt => opt.MapFrom(src => new List<Vehicle> { src }));

            CreateMap<Branch, VehicleShowViewModel>()
                .ForMember(dest => dest.Branches, opt => opt.MapFrom(src => new List<Branch> { src }));
        }
    }
}
