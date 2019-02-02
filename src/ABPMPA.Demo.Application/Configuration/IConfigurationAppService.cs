using System.Threading.Tasks;
using ABPMPA.Demo.Configuration.Dto;

namespace ABPMPA.Demo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
