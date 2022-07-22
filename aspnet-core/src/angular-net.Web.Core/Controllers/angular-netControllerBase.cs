using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace angular-net.Controllers
{
    public abstract class angular-netControllerBase: AbpController
    {
        protected angular-netControllerBase()
        {
            LocalizationSourceName = angular-netConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
