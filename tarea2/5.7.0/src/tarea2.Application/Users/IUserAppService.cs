using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tarea2.Roles.Dto;
using tarea2.Users.Dto;

namespace tarea2.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}