using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace StudyPro.Controllers
{
    public abstract class StudyProControllerBase: AbpController
    {
        protected StudyProControllerBase()
        {
            LocalizationSourceName = StudyProConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
