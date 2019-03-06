using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Super.Admin.Configuration.Dto;

namespace Super.Admin.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AdminAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
