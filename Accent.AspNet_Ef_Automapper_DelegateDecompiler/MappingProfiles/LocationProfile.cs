using Accent.DotNetExperiments.Dtos;
using Accent.DotNetExperiments.Entities;
using AutoMapper;

namespace Accent.DotNetExperiments.MappingProfiles
{
    public class LocationProfile : Profile
    {
        public LocationProfile()
        {
            CreateMap<Location, LocationDto>();
        }
    }
}
