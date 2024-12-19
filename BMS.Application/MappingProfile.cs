namespace BMS.Application
{
    using AutoMapper;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Core.Entities.Book, DTOs.Book>().ReverseMap();
        }
    }
}