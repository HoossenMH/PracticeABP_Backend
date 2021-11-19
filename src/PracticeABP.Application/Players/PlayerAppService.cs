using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;

using PracticeABP.Authorization;
using PracticeABP.Players.Dto;

using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeABP.Players
{
    [AbpAuthorize(PermissionNames.Pages_Players)]
    public class PlayerAppService : CrudAppService<Player, PlayerDto>
    {
        public PlayerAppService(IRepository<Player, int> repository) : 
            base(repository)
        {

        }
    }
}
