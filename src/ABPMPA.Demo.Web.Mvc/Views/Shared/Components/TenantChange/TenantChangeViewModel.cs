using Abp.AutoMapper;
using ABPMPA.Demo.Sessions.Dto;

namespace ABPMPA.Demo.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
