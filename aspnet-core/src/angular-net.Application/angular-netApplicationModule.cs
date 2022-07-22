using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using angular-net.Authorization;

namespace angular-net
{
    [DependsOn(
        typeof(angular-netCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class angular-netApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<angular-netAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(angular-netApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
