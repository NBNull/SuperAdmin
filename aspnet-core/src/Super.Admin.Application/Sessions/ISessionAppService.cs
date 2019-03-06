using System.Threading.Tasks;
using Abp.Application.Services;
using Super.Admin.Sessions.Dto;

namespace Super.Admin.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
