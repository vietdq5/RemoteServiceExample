using RemoteServiceExample.Entities.Dtos;
using AutoMapper;

namespace RemoteServiceExample.Web
{
    public class RemoteServiceExampleWebAutoMapperProfile : Profile
    {
        public RemoteServiceExampleWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.
            CreateMap<BookDto, CreateUpdateBookDto>();
        }
    }
}
