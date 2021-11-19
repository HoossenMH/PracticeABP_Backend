using System.Threading.Tasks;
using Abp.Application.Services;
using PracticeABP.Authorization.Accounts.Dto;

namespace PracticeABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
