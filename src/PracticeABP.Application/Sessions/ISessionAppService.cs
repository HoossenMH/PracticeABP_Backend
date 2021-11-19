using System.Threading.Tasks;
using Abp.Application.Services;
using PracticeABP.Sessions.Dto;

namespace PracticeABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
