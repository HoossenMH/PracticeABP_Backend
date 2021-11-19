using System.Threading.Tasks;
using PracticeABP.Configuration.Dto;

namespace PracticeABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
