using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PracticeABP.Roles.Dto;
using PracticeABP.Users.Dto;

namespace PracticeABP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
