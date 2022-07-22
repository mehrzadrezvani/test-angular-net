using System.Threading.Tasks;
using Abp.Application.Services;
using angular-net.Sessions.Dto;

namespace angular-net.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
