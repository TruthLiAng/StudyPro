using Abp.Authorization;
using StudyPro.Authorization.Roles;
using StudyPro.Authorization.Users;

namespace StudyPro.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
