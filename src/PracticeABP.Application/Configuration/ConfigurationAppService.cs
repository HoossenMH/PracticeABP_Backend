using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PracticeABP.Configuration.Dto;

namespace PracticeABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PracticeABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
