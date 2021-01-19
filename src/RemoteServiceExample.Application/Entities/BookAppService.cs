using System;
using RemoteServiceExample.Entities.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace RemoteServiceExample.Entities
{
    public class BookAppService : CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto, CreateUpdateBookDto>,
        IBookAppService
    {

        private readonly IBookRepository _repository;
        
        public BookAppService(IBookRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
