using System.Threading.Tasks;
using Abp.Application.Services;
using ABPMPA.Demo.Sessions.Dto;

namespace ABPMPA.Demo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
