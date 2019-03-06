using System.Threading.Tasks;
using Super.Admin.Configuration.Dto;

namespace Super.Admin.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
