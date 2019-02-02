using Abp.Authorization;
using ABPMPA.Demo.Authorization.Roles;
using ABPMPA.Demo.Authorization.Users;

namespace ABPMPA.Demo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
