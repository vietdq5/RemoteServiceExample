﻿using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace RemoteServiceExample.Data
{
    /* This is used if database provider does't define
     * IRemoteServiceExampleDbSchemaMigrator implementation.
     */
    public class NullRemoteServiceExampleDbSchemaMigrator : IRemoteServiceExampleDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}