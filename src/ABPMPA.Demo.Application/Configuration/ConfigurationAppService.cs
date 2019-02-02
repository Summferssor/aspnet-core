using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPMPA.Demo.Configuration.Dto;

namespace ABPMPA.Demo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
