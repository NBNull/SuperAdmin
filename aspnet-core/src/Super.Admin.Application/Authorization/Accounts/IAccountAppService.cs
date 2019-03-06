using System.Threading.Tasks;
using Abp.Application.Services;
using Super.Admin.Authorization.Accounts.Dto;

namespace Super.Admin.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
