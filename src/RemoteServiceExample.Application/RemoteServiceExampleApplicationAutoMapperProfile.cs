using RemoteServiceExample.Entities;
using RemoteServiceExample.Entities.Dtos;
using AutoMapper;

namespace RemoteServiceExample
{
    public class RemoteServiceExampleApplicationAutoMapperProfile : Profile
    {
        public RemoteServiceExampleApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>(MemberList.Source);
        }
    }
}
