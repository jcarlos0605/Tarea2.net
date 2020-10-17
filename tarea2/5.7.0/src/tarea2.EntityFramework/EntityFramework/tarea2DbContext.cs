using System.Data.Common;
using System.Data.Entity;
using Abp.DynamicEntityProperties;
using Abp.Zero.EntityFramework;
using tarea2.Authorization.Roles;
using tarea2.Authorization.Users;
using tarea2.Features.clientes;
using tarea2.Features.Productos;
using tarea2.MultiTenancy;

namespace tarea2.EntityFramework
{
    public class tarea2DbContext : AbpZeroDbContext<Tenant, Role, User>
    {
       DbSet<Productos>Producto { get; set; }

        DbSet<Cliente> clientes { get; set; }

        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public tarea2DbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in tarea2DataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of tarea2DbContext since ABP automatically handles it.
         */
        public tarea2DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public tarea2DbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public tarea2DbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DynamicProperty>().Property(p => p.PropertyName).HasMaxLength(250);
            modelBuilder.Entity<DynamicEntityProperty>().Property(p => p.EntityFullName).HasMaxLength(250);
        }
    }
}
