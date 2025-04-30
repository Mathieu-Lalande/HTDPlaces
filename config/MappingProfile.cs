using AutoMapper;
using HTDPlaces.Models;
using HTDPlaces.ViewModels;

namespace HTDPlaces.config
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Event, EventViewModel>()
                .ForMember(dest => dest.Participants, opt => opt.MapFrom(src => src.Participants.Select(p => p.UserName)))
                .ForMember(dest => dest.Creator, opt => opt.MapFrom(src => src.Creator.UserName))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name));
            
            
            CreateMap<Category, CategoryViewModel>()
                .ReverseMap();
        }
    }
}
