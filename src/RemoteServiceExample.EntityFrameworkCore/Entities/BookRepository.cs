using System;
using RemoteServiceExample.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace RemoteServiceExample.Entities
{
    public class BookRepository : EfCoreRepository<RemoteServiceExampleDbContext, Book, Guid>, IBookRepository
    {
        public BookRepository(IDbContextProvider<RemoteServiceExampleDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}