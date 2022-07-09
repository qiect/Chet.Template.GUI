using Chet.Template.GUI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;

namespace Chet.Template.GUI.ApplicationService
{
    [DependsOn(typeof(TemplateGUIDomainModule))]
    public class TemplateGUIApplicationService:AbpModule
    {

    }
}
