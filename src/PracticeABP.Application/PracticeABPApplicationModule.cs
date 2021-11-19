using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PracticeABP.Authorization;

namespace PracticeABP
{
    [DependsOn(
        typeof(PracticeABPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PracticeABPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PracticeABPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PracticeABPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
