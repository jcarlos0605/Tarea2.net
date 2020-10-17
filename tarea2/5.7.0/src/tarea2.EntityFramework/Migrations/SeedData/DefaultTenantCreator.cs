using System.Linq;
using tarea2.EntityFramework;
using tarea2.MultiTenancy;

namespace tarea2.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly tarea2DbContext _context;

        public DefaultTenantCreator(tarea2DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
