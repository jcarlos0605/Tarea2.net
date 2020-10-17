using System.Threading.Tasks;
using Abp.Application.Services;
using tarea2.Sessions.Dto;

namespace tarea2.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
