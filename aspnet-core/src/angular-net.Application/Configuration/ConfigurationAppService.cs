using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using angular-net.Configuration.Dto;

namespace angular-net.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : angular-netAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
