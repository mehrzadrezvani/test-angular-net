using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using angular-net.Configuration;

namespace angular-net.Web.Host.Startup
{
    [DependsOn(
       typeof(angular-netWebCoreModule))]
    public class angular-netWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public angular-netWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(angular-netWebHostModule).GetAssembly());
        }
    }
}
