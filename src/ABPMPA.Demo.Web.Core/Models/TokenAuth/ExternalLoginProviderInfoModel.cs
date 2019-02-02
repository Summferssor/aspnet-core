using Abp.AutoMapper;
using ABPMPA.Demo.Authentication.External;

namespace ABPMPA.Demo.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
