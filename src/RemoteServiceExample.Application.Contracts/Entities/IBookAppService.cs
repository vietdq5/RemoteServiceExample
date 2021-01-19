using System;
using RemoteServiceExample.Entities.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace RemoteServiceExample.Entities
{
    public interface IBookAppService :
        ICrudAppService< 
            BookDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateBookDto,
            CreateUpdateBookDto>
    {

    }
}