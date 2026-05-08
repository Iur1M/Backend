using AutoMapper;
using ProjectBackend.Domain.Contracts;
using ProjectBackend.Domain.Entities;

namespace ProjectBackend.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserResponse>();
            CreateMap<ApplicationUser, CurrentUserResponse>();

            CreateMap<UserRegisterRequest, ApplicationUser>()
                .ForMember(dest => dest.UserName, opt => opt.Ignore());

            CreateMap<Movie, MovieDto>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ReverseMap();

            CreateMap<AddMovieDto, Movie>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
        }
    }
}
