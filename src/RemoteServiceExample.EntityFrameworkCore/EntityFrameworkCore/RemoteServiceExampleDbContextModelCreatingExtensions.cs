using RemoteServiceExample.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace RemoteServiceExample.EntityFrameworkCore
{
    public static class RemoteServiceExampleDbContextModelCreatingExtensions
    {
        public static void ConfigureRemoteServiceExample(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(RemoteServiceExampleConsts.DbTablePrefix + "YourEntities", RemoteServiceExampleConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});


            builder.Entity<Book>(b =>
            {
                b.ToTable(RemoteServiceExampleConsts.DbTablePrefix + "Books", RemoteServiceExampleConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });
        }
    }
}
