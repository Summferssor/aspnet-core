using Abp.AspNetCore.Mvc.ViewComponents;

namespace ABPMPA.Demo.Web.Views
{
    public abstract class DemoViewComponent : AbpViewComponent
    {
        protected DemoViewComponent()
        {
            LocalizationSourceName = DemoConsts.LocalizationSourceName;
        }
    }
}
