using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace ABPMPA.Demo.Web.Views
{
    public abstract class DemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected DemoRazorPage()
        {
            LocalizationSourceName = DemoConsts.LocalizationSourceName;
        }
    }
}
