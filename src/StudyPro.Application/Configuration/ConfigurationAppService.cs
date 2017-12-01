using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using StudyPro.Configuration.Dto;

namespace StudyPro.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : StudyProAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
