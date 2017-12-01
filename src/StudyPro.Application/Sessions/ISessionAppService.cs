using System.Threading.Tasks;
using Abp.Application.Services;
using StudyPro.Sessions.Dto;

namespace StudyPro.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
