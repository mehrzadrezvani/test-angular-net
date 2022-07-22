using Abp.Authorization;
using angular-net.Authorization.Roles;
using angular-net.Authorization.Users;

namespace angular-net.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
