using Abp.Application.Services;
using angular-net.MultiTenancy.Dto;

namespace angular-net.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

