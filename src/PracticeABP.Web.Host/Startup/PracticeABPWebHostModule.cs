using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PracticeABP.Configuration;

namespace PracticeABP.Web.Host.Startup
{
    [DependsOn(
       typeof(PracticeABPWebCoreModule))]
    public class PracticeABPWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PracticeABPWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PracticeABPWebHostModule).GetAssembly());
        }
    }
}
