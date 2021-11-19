using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PracticeABP.MultiTenancy.Dto;

namespace PracticeABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

