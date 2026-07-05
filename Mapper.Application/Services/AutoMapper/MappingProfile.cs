using AutoMapper;
using Mapper.Application.Models.DTO;
using Mapper.Domain.Entities;
using Mapper.Domain.Entities.Commons;


namespace Mapper.Application.Services.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            MappingComputer();
        
        }


        private void MappingComputer()
        {
            CreateMap<Computer, ComputerDto>()
                .Include<Computer, ComputerDto>()
                .Include<Notebook,NotebookDto>();
            CreateMap<ComputerDto, Computer>()
                .ForMember(dest => dest.Id, opt => opt.Condition( src => src.Id != null));


            CreateMap<Notebook, NotebookDto>();



            CreateMap<NotebookDto, Notebook>();
            CreateMap<Desktop, DesktopDto>();
            CreateMap<DesktopDto, Desktop>();

        }
    }
}
