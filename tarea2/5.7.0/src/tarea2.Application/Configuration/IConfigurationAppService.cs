using System.Threading.Tasks;
using Abp.Application.Services;
using tarea2.Configuration.Dto;

namespace tarea2.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}