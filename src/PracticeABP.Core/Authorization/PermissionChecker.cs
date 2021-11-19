using Abp.Authorization;
using PracticeABP.Authorization.Roles;
using PracticeABP.Authorization.Users;

namespace PracticeABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
