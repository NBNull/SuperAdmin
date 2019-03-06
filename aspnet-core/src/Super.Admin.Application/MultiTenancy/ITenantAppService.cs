using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Super.Admin.MultiTenancy.Dto;

namespace Super.Admin.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

