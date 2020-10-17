using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using tarea2.EntityFramework;

namespace tarea2.Migrator
{
    [DependsOn(typeof(tarea2DataModule))]
    public class tarea2MigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<tarea2DbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}