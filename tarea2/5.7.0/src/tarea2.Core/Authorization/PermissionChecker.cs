using Abp.Authorization;
using tarea2.Authorization.Roles;
using tarea2.Authorization.Users;

namespace tarea2.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
