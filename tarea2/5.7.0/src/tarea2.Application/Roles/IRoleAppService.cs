using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tarea2.Roles.Dto;

namespace tarea2.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
