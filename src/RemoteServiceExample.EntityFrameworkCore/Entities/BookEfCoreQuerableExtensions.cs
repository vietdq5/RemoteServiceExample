using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RemoteServiceExample.Entities
{
    public static class BookEfCoreQueryableExtensions
    {
        public static IQueryable<Book> IncludeDetails(this IQueryable<Book> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}