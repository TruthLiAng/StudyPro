using Abp.Application.Services;
using Abp.Application.Services.Dto;
using StudyPro.MultiTenancy.Dto;

namespace StudyPro.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
