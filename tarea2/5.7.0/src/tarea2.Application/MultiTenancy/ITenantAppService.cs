using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tarea2.MultiTenancy.Dto;

namespace tarea2.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
