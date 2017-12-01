using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using StudyPro.Authorization;

namespace StudyPro
{
    [DependsOn(
        typeof(StudyProCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class StudyProApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<StudyProAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(StudyProApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
