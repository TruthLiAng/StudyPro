using System.Threading.Tasks;
using Abp.Application.Services;
using StudyPro.Authorization.Accounts.Dto;

namespace StudyPro.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
