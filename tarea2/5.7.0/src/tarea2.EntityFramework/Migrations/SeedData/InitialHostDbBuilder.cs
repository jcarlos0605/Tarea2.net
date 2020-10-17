using tarea2.EntityFramework;
using EntityFramework.DynamicFilters;

namespace tarea2.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly tarea2DbContext _context;

        public InitialHostDbBuilder(tarea2DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
