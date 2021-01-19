using Microsoft.EntityFrameworkCore;
using RemoteServiceExample.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;
using RemoteServiceExample.Entities;

namespace RemoteServiceExample.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See RemoteServiceExampleMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class RemoteServiceExampleDbContext : AbpDbContext<RemoteServiceExampleDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside RemoteServiceExampleDbContextModelCreatingExtensions.ConfigureRemoteServiceExample
         */
        public DbSet<Book> Books { get; set; }

        public RemoteServiceExampleDbContext(DbContextOptions<RemoteServiceExampleDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the RemoteServiceExampleEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureRemoteServiceExample method */

            builder.ConfigureRemoteServiceExample();
        }
    }
}
