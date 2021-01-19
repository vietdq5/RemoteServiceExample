using System;
using Volo.Abp.Domain.Repositories;

namespace RemoteServiceExample.Entities
{
    public interface IBookRepository : IRepository<Book, Guid>
    {
    }
}