using Chet.Template.GUI.ApplicationService;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Chet.Template.GUI
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TemplateGUIApplicationService))]
    public class GUIModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<MainWindow>();
        }
    }
}
