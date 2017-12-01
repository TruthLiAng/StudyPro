using System.Threading.Tasks;
using StudyPro.Configuration.Dto;

namespace StudyPro.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
