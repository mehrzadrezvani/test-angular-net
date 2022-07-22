using System.Threading.Tasks;
using angular-net.Configuration.Dto;

namespace angular-net.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
