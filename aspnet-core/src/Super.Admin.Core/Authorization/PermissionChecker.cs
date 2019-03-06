using Abp.Authorization;
using Super.Admin.Authorization.Roles;
using Super.Admin.Authorization.Users;

namespace Super.Admin.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
