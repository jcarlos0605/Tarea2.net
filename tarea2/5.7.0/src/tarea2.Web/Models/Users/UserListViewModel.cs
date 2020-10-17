using System.Collections.Generic;
using tarea2.Roles.Dto;
using tarea2.Users.Dto;

namespace tarea2.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}