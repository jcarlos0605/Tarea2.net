using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using tarea2.Configuration.Dto;

namespace tarea2.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : tarea2AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
