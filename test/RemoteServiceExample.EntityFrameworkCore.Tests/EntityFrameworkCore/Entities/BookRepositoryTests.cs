using System;
using System.Threading.Tasks;
using RemoteServiceExample.Entities;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace RemoteServiceExample.EntityFrameworkCore.Entities
{
    public class BookRepositoryTests : RemoteServiceExampleEntityFrameworkCoreTestBase
    {
        private readonly IBookRepository _bookRepository;

        public BookRepositoryTests()
        {
            _bookRepository = GetRequiredService<IBookRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
