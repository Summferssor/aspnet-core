using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPMPA.Demo.MultiTenancy.Dto;

namespace ABPMPA.Demo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

