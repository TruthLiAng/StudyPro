using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using StudyPro.Configuration;

namespace StudyPro.Web.Host.Startup
{
    [DependsOn(
       typeof(StudyProWebCoreModule))]
    public class StudyProWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public StudyProWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StudyProWebHostModule).GetAssembly());
        }
    }
}
